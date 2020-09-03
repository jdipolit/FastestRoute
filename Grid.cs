using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastestRoute
{
    public partial class Grid : Form
    {
        private int GridWidth;
        private int GridHeight;
        private Graph CartesianPlane;
        private List<Node> Route;
        public Grid()
        {
            InitializeComponent();

            CartesianPlane = new Graph();
            Route = new List<Node>();
#if DEBUG
            txt_gridsize_height.Text = "50";
            txt_gridsize_width.Text = "50";

            GridWidth = 50;
            GridHeight = 50;
            btn_gridsize_set.Enabled = false;
            txt_gridsize_height.Enabled = false;
            txt_gridsize_width.Enabled = false;

            Node a = new Node("A", 25, 35);
            Node b = new Node("B", 12,  3);
            Node c = new Node("C", 22, 44);
            Node d = new Node("D", 31, 40);
            Node e = new Node("E", 10, 10);
            Node f = new Node("F",  5, 12);

            CartesianPlane.AddVertex(a);
            CartesianPlane.AddVertex(b);
            CartesianPlane.AddVertex(c);
            CartesianPlane.AddVertex(d);
            CartesianPlane.AddVertex(e);
            CartesianPlane.AddVertex(f);
            
            CartesianPlane.AddEdge(a, b);
            CartesianPlane.AddEdge(a, c);
            CartesianPlane.AddEdge(c, d);
            CartesianPlane.AddEdge(b, e);
            CartesianPlane.AddEdge(e, f);
            CartesianPlane.AddEdge(f, b);

            UpdateVerticesList();
#endif
        }

        private void btn_gridsize_set_Click(object sender, EventArgs e)
        {
            //Check if input is valid
            if (!IsNumber(txt_gridsize_height.Text))
            {
                MessageBox.Show("Grid height is invalid");
                return;
            }
            if (!IsNumber(txt_gridsize_height.Text)) 
            {
                MessageBox.Show("Grid width is invalid");
                return;
            }
            //

            //Set main variables values
            GridWidth  = Convert.ToInt32(txt_gridsize_width.Text);
            GridHeight = Convert.ToInt32(txt_gridsize_height.Text);

            //disable the controls so it cannot be modified after set
            btn_gridsize_set.Enabled = false;
            txt_gridsize_height.Enabled = false;
            txt_gridsize_width.Enabled = false;

            //draw the grid with the size set
            pnl_grid.Invalidate(); //this will call the panel's Paint method
        }

        private bool IsNumber(string text)
        {
            return int.TryParse(text, out int number);
        }

        private void UpdateVerticesList()
        {
            cmb_vetices_list.Items.Clear();
            cmb_vetices_list.Items.Add("ADD NEW");
            foreach (var node in CartesianPlane.Matrix)
            {
                cmb_route_from.Items.Add(node.Value.Name);
                cmb_route_to.Items.Add(node.Value.Name);
                cmb_vetices_list.Items.Add(node.Value.Name);
            }
        }

        private void pnl_grid_Paint(object sender, PaintEventArgs e)
        {            
            //set color and border
            pnl_grid.BackColor = Color.White;
            pnl_grid.BorderStyle = BorderStyle.FixedSingle;

            //check the distance from each line to be drawn
            double verticalLineSpacing = (double)pnl_grid.Width / GridWidth;
            double horizontalLineSpacing = (double)pnl_grid.Height / GridHeight;

            //create the pen
            Pen gridPen = new Pen(Color.Gray);
            gridPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            
            Pen edgePen = new Pen(Color.Black, 5);
            Pen edgePenArrow = new Pen(Color.YellowGreen, 5);
            Pen edgePenRoute = new Pen(Color.Orange, 5);

            //create the font
            Font font = new Font("Arial", 18, FontStyle.Bold);

            //create the brush
            Brush brush = new SolidBrush(Color.Red);
            Brush brush2 = new SolidBrush(Color.YellowGreen);

            //get panel graphics to draw later
            Graphics graphics = pnl_grid.CreateGraphics();

            //draw vertical lines
            for (double x = verticalLineSpacing; x < pnl_grid.Width; x += verticalLineSpacing)
                graphics.DrawLine(gridPen, (int)x, 0, (int)x, pnl_grid.Height);

            for (double y = horizontalLineSpacing; y < pnl_grid.Height; y += horizontalLineSpacing)
                graphics.DrawLine(gridPen, 0, (int)y, pnl_grid.Width, (int)y);

            //draw all edges
            foreach (var vertex in CartesianPlane.Matrix)
            {
                int vx = (int)(vertex.Value.X * verticalLineSpacing);
                int vy = (int)(vertex.Value.Y * horizontalLineSpacing);                

                foreach (Node edge in vertex.Value.Edges)
                {
                    int ex = (int)(edge.X * verticalLineSpacing);
                    int ey = (int)(edge.Y * horizontalLineSpacing);

                    if(Route.IndexOf(vertex.Value) >= 0 && Route.IndexOf(edge) >= 0  && Route.IndexOf(edge)-1 == Route.IndexOf(vertex.Value))
                        
                        graphics.DrawLine(edgePenRoute, vx, vy, ex, ey);
                    else
                        graphics.DrawLine(edgePen, vx, vy, ex, ey);
                }
            }

            //draw all edge directions
            foreach (var vertex in CartesianPlane.Matrix)
            {
                int vx = (int)(vertex.Value.X * verticalLineSpacing);
                int vy = (int)(vertex.Value.Y * horizontalLineSpacing);

                foreach (Node edge in vertex.Value.Edges)
                {
                    //base line
                    int ex = (int)(edge.X * verticalLineSpacing);
                    int ey = (int)(edge.Y * horizontalLineSpacing);

                    double alpha = Math.Atan2(vy - ey, vx - ex);
                    int nx = (int)(ex + verticalLineSpacing * Math.Cos(alpha));
                    int ny = (int)(ey + verticalLineSpacing * Math.Sin(alpha));

                    graphics.DrawLine(edgePenArrow, ex, ey, nx, ny);

                    //Triangle
                    int distance = (int)(verticalLineSpacing / 2);                    

                    double midalpha = Math.Atan2(vy - ey, vx - ex);
                    int midx = (int)(ex + distance * Math.Cos(midalpha));
                    int midy = (int)(ey + distance * Math.Sin(midalpha));                    

                    double alphaPlus = Math.Atan2(ey - midy, ex - midx) + 90;
                    int plusx = (int)(midx + distance * Math.Cos(alphaPlus));
                    int plusy = (int)(midy + distance * Math.Sin(alphaPlus));                    

                    double alphaMinus = Math.Atan2(ey - midy, ex - midx) - 90;                    
                    int minusx = (int)(midx + distance * Math.Cos(alphaMinus));
                    int minusy = (int)(midy + distance * Math.Sin(alphaMinus));
                   
                    PointF[] triangle = new PointF[]
                    {
                        new PointF(ex, ey),
                        new PointF(minusx, minusy),
                        new PointF(midx, midy),
                        new PointF(plusx, plusy)
                    };

                    graphics.FillPolygon(brush2, triangle);
                }
            }

            //draw all vertices
            foreach (var vertex in CartesianPlane.Matrix)
            {
                int vx = (int)(vertex.Value.X * verticalLineSpacing);
                int vy = (int)(vertex.Value.Y * horizontalLineSpacing);
                int rectSize = 6;

                graphics.DrawString(vertex.Key, font, brush, vx, vy); //draw the name
                graphics.FillRectangle(brush, vx - (rectSize / 2), vy - (rectSize / 2), rectSize, rectSize); //drawing a point
            }
        }

        private void btn_vertices_add_update_Click(object sender, EventArgs e)
        {
            //add operation
            //Check if input is valid
            if(string.IsNullOrEmpty(txt_vertices_name.Text))
            {
                MessageBox.Show("Vertex Name is invalid");
                return;
            }
            if (!IsNumber(txt_vertices_x.Text) && int.Parse(txt_vertices_x.Text) >= 0 && int.Parse(txt_vertices_x.Text) <= GridWidth)
            {
                MessageBox.Show("Vertex X is invalid");
                return;
            }
            if (!IsNumber(txt_vertices_y.Text) && int.Parse(txt_vertices_y.Text) >= 0 && int.Parse(txt_vertices_y.Text) <= GridHeight)
            {
                MessageBox.Show("Vertex Y is invalid");
                return;
            }            
            //

            //update method
            Node node = CartesianPlane.GetVertex(txt_vertices_name.Text);
            if (node != null)
            {
                node.X = Convert.ToInt32(txt_vertices_x.Text);
                node.Y = Convert.ToInt32(txt_vertices_y.Text);
                node.Edges.Clear();
                for(int index = 0; index < chb_vertices_edges.Items.Count; index++)
                {
                    if (chb_vertices_edges.GetItemChecked(index))
                        node.Edges.AddFirst(CartesianPlane.GetVertex(chb_vertices_edges.Items[index].ToString()));
                }
            }
            else //add method
            {
                CartesianPlane.AddVertex(
                new Node(txt_vertices_name.Text,
                Convert.ToInt32(txt_vertices_x.Text),
                Convert.ToInt32(txt_vertices_y.Text)));

                UpdateVerticesList();
            }

            Route.Clear();
            pnl_grid.Invalidate(); //refresh the grid
            cmb_vetices_list.SelectedIndex = 0;
        }

        private void cmb_vetices_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_vetices_list.SelectedItem == "ADD NEW")
            {
                txt_vertices_name.Clear();
                txt_vertices_x.Clear();
                txt_vertices_y.Clear();
                chb_vertices_edges.Items.Clear();
                txt_vertices_name.Enabled = true; 
            }
            else
            {
                Node vertex = CartesianPlane.GetVertex(cmb_vetices_list.SelectedItem.ToString());
                txt_vertices_name.Text = vertex.Name;
                txt_vertices_x.Text = vertex.X.ToString();
                txt_vertices_y.Text = vertex.Y.ToString();
                txt_vertices_name.Enabled = false; //will not let the user change the name otherwise I will lose the key reference

                chb_vertices_edges.Items.Clear();
                int chbIndex = 0;
                foreach (var node in CartesianPlane.Matrix)
                {
                    if (node.Key != vertex.Name)
                    {
                        chb_vertices_edges.Items.Add(node.Key);
                        if (vertex.Edges.Find(node.Value) != null)
                            chb_vertices_edges.SetItemChecked(chbIndex, true);
                        chbIndex++;
                    }
                }

            }
        }

        private void btn_route_find_Click(object sender, EventArgs e)
        {
            Node origin = CartesianPlane.GetVertex(cmb_route_from.SelectedItem.ToString());
            Node target = CartesianPlane.GetVertex(cmb_route_to.SelectedItem.ToString());

            Route = CartesianPlane.DepthFirstSearch(origin, target);
            pnl_grid.Invalidate();

            string display = "";
            foreach(var point in Route)
            {
                display += $"{point.Name} --> ";
            }

            MessageBox.Show(display);
        }
    }
}