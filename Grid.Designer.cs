namespace FastestRoute
{
    partial class Grid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grb_gridsize = new System.Windows.Forms.GroupBox();
            this.btn_gridsize_set = new System.Windows.Forms.Button();
            this.lbl_gridsize_pxwidth = new System.Windows.Forms.Label();
            this.lbl_gridsize_pxheight = new System.Windows.Forms.Label();
            this.txt_gridsize_width = new System.Windows.Forms.TextBox();
            this.txt_gridsize_height = new System.Windows.Forms.TextBox();
            this.lbl_gridsize_width = new System.Windows.Forms.Label();
            this.lbl_gridsize_height = new System.Windows.Forms.Label();
            this.grb_vertices = new System.Windows.Forms.GroupBox();
            this.chb_vertices_edges = new System.Windows.Forms.CheckedListBox();
            this.btn_vertices_add_update = new System.Windows.Forms.Button();
            this.lbl_vertices_pxy = new System.Windows.Forms.Label();
            this.lbl_vertices_pxx = new System.Windows.Forms.Label();
            this.txt_vertices_y = new System.Windows.Forms.TextBox();
            this.txt_vertices_x = new System.Windows.Forms.TextBox();
            this.lbl_vertices_y = new System.Windows.Forms.Label();
            this.lbl_vertices_x = new System.Windows.Forms.Label();
            this.pnl_grid = new System.Windows.Forms.Panel();
            this.txt_vertices_name = new System.Windows.Forms.TextBox();
            this.lbl_vertices_name = new System.Windows.Forms.Label();
            this.cmb_vetices_list = new System.Windows.Forms.ComboBox();
            this.btn_route_find = new System.Windows.Forms.Button();
            this.cmb_route_from = new System.Windows.Forms.ComboBox();
            this.grb_route = new System.Windows.Forms.GroupBox();
            this.cmb_route_to = new System.Windows.Forms.ComboBox();
            this.lbl_route_from = new System.Windows.Forms.Label();
            this.lbl_route_to = new System.Windows.Forms.Label();
            this.grb_gridsize.SuspendLayout();
            this.grb_vertices.SuspendLayout();
            this.grb_route.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_gridsize
            // 
            this.grb_gridsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_gridsize.Controls.Add(this.btn_gridsize_set);
            this.grb_gridsize.Controls.Add(this.lbl_gridsize_pxwidth);
            this.grb_gridsize.Controls.Add(this.lbl_gridsize_pxheight);
            this.grb_gridsize.Controls.Add(this.txt_gridsize_width);
            this.grb_gridsize.Controls.Add(this.txt_gridsize_height);
            this.grb_gridsize.Controls.Add(this.lbl_gridsize_width);
            this.grb_gridsize.Controls.Add(this.lbl_gridsize_height);
            this.grb_gridsize.Location = new System.Drawing.Point(724, 12);
            this.grb_gridsize.Name = "grb_gridsize";
            this.grb_gridsize.Size = new System.Drawing.Size(154, 115);
            this.grb_gridsize.TabIndex = 0;
            this.grb_gridsize.TabStop = false;
            this.grb_gridsize.Text = "Set the grid size";
            // 
            // btn_gridsize_set
            // 
            this.btn_gridsize_set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gridsize_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gridsize_set.Location = new System.Drawing.Point(9, 83);
            this.btn_gridsize_set.Name = "btn_gridsize_set";
            this.btn_gridsize_set.Size = new System.Drawing.Size(135, 24);
            this.btn_gridsize_set.TabIndex = 2;
            this.btn_gridsize_set.Text = "Set";
            this.btn_gridsize_set.UseVisualStyleBackColor = true;
            this.btn_gridsize_set.Click += new System.EventHandler(this.btn_gridsize_set_Click);
            // 
            // lbl_gridsize_pxwidth
            // 
            this.lbl_gridsize_pxwidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_gridsize_pxwidth.AutoSize = true;
            this.lbl_gridsize_pxwidth.Location = new System.Drawing.Point(115, 56);
            this.lbl_gridsize_pxwidth.Name = "lbl_gridsize_pxwidth";
            this.lbl_gridsize_pxwidth.Size = new System.Drawing.Size(23, 18);
            this.lbl_gridsize_pxwidth.TabIndex = 5;
            this.lbl_gridsize_pxwidth.Text = "px";
            // 
            // lbl_gridsize_pxheight
            // 
            this.lbl_gridsize_pxheight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_gridsize_pxheight.AutoSize = true;
            this.lbl_gridsize_pxheight.Location = new System.Drawing.Point(115, 26);
            this.lbl_gridsize_pxheight.Name = "lbl_gridsize_pxheight";
            this.lbl_gridsize_pxheight.Size = new System.Drawing.Size(23, 18);
            this.lbl_gridsize_pxheight.TabIndex = 4;
            this.lbl_gridsize_pxheight.Text = "px";
            // 
            // txt_gridsize_width
            // 
            this.txt_gridsize_width.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_gridsize_width.Location = new System.Drawing.Point(62, 53);
            this.txt_gridsize_width.Name = "txt_gridsize_width";
            this.txt_gridsize_width.Size = new System.Drawing.Size(51, 24);
            this.txt_gridsize_width.TabIndex = 1;
            // 
            // txt_gridsize_height
            // 
            this.txt_gridsize_height.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_gridsize_height.Location = new System.Drawing.Point(62, 23);
            this.txt_gridsize_height.Name = "txt_gridsize_height";
            this.txt_gridsize_height.Size = new System.Drawing.Size(51, 24);
            this.txt_gridsize_height.TabIndex = 0;
            // 
            // lbl_gridsize_width
            // 
            this.lbl_gridsize_width.AutoSize = true;
            this.lbl_gridsize_width.Location = new System.Drawing.Point(10, 56);
            this.lbl_gridsize_width.Name = "lbl_gridsize_width";
            this.lbl_gridsize_width.Size = new System.Drawing.Size(50, 18);
            this.lbl_gridsize_width.TabIndex = 1;
            this.lbl_gridsize_width.Text = "Width:";
            // 
            // lbl_gridsize_height
            // 
            this.lbl_gridsize_height.AutoSize = true;
            this.lbl_gridsize_height.Location = new System.Drawing.Point(6, 26);
            this.lbl_gridsize_height.Name = "lbl_gridsize_height";
            this.lbl_gridsize_height.Size = new System.Drawing.Size(54, 18);
            this.lbl_gridsize_height.TabIndex = 0;
            this.lbl_gridsize_height.Text = "Height:";
            // 
            // grb_vertices
            // 
            this.grb_vertices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_vertices.Controls.Add(this.cmb_vetices_list);
            this.grb_vertices.Controls.Add(this.txt_vertices_name);
            this.grb_vertices.Controls.Add(this.lbl_vertices_name);
            this.grb_vertices.Controls.Add(this.chb_vertices_edges);
            this.grb_vertices.Controls.Add(this.btn_vertices_add_update);
            this.grb_vertices.Controls.Add(this.lbl_vertices_pxy);
            this.grb_vertices.Controls.Add(this.lbl_vertices_pxx);
            this.grb_vertices.Controls.Add(this.txt_vertices_y);
            this.grb_vertices.Controls.Add(this.txt_vertices_x);
            this.grb_vertices.Controls.Add(this.lbl_vertices_y);
            this.grb_vertices.Controls.Add(this.lbl_vertices_x);
            this.grb_vertices.Location = new System.Drawing.Point(724, 133);
            this.grb_vertices.Name = "grb_vertices";
            this.grb_vertices.Size = new System.Drawing.Size(154, 329);
            this.grb_vertices.TabIndex = 7;
            this.grb_vertices.TabStop = false;
            this.grb_vertices.Text = "Add to the grid";
            // 
            // chb_vertices_edges
            // 
            this.chb_vertices_edges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_vertices_edges.FormattingEnabled = true;
            this.chb_vertices_edges.Location = new System.Drawing.Point(9, 157);
            this.chb_vertices_edges.Name = "chb_vertices_edges";
            this.chb_vertices_edges.Size = new System.Drawing.Size(135, 118);
            this.chb_vertices_edges.TabIndex = 3;
            // 
            // btn_vertices_add_update
            // 
            this.btn_vertices_add_update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_vertices_add_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vertices_add_update.Location = new System.Drawing.Point(9, 297);
            this.btn_vertices_add_update.Name = "btn_vertices_add_update";
            this.btn_vertices_add_update.Size = new System.Drawing.Size(135, 24);
            this.btn_vertices_add_update.TabIndex = 4;
            this.btn_vertices_add_update.Text = "Add / Update";
            this.btn_vertices_add_update.UseVisualStyleBackColor = true;
            this.btn_vertices_add_update.Click += new System.EventHandler(this.btn_vertices_add_update_Click);
            // 
            // lbl_vertices_pxy
            // 
            this.lbl_vertices_pxy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_vertices_pxy.AutoSize = true;
            this.lbl_vertices_pxy.Location = new System.Drawing.Point(115, 127);
            this.lbl_vertices_pxy.Name = "lbl_vertices_pxy";
            this.lbl_vertices_pxy.Size = new System.Drawing.Size(23, 18);
            this.lbl_vertices_pxy.TabIndex = 5;
            this.lbl_vertices_pxy.Text = "px";
            // 
            // lbl_vertices_pxx
            // 
            this.lbl_vertices_pxx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_vertices_pxx.AutoSize = true;
            this.lbl_vertices_pxx.Location = new System.Drawing.Point(115, 97);
            this.lbl_vertices_pxx.Name = "lbl_vertices_pxx";
            this.lbl_vertices_pxx.Size = new System.Drawing.Size(23, 18);
            this.lbl_vertices_pxx.TabIndex = 4;
            this.lbl_vertices_pxx.Text = "px";
            // 
            // txt_vertices_y
            // 
            this.txt_vertices_y.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_vertices_y.Location = new System.Drawing.Point(62, 124);
            this.txt_vertices_y.Name = "txt_vertices_y";
            this.txt_vertices_y.Size = new System.Drawing.Size(51, 24);
            this.txt_vertices_y.TabIndex = 2;
            // 
            // txt_vertices_x
            // 
            this.txt_vertices_x.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_vertices_x.Location = new System.Drawing.Point(62, 94);
            this.txt_vertices_x.Name = "txt_vertices_x";
            this.txt_vertices_x.Size = new System.Drawing.Size(51, 24);
            this.txt_vertices_x.TabIndex = 1;
            // 
            // lbl_vertices_y
            // 
            this.lbl_vertices_y.AutoSize = true;
            this.lbl_vertices_y.Location = new System.Drawing.Point(39, 127);
            this.lbl_vertices_y.Name = "lbl_vertices_y";
            this.lbl_vertices_y.Size = new System.Drawing.Size(21, 18);
            this.lbl_vertices_y.TabIndex = 1;
            this.lbl_vertices_y.Text = "Y:";
            // 
            // lbl_vertices_x
            // 
            this.lbl_vertices_x.AutoSize = true;
            this.lbl_vertices_x.Location = new System.Drawing.Point(38, 97);
            this.lbl_vertices_x.Name = "lbl_vertices_x";
            this.lbl_vertices_x.Size = new System.Drawing.Size(22, 18);
            this.lbl_vertices_x.TabIndex = 0;
            this.lbl_vertices_x.Text = "X:";
            // 
            // pnl_grid
            // 
            this.pnl_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_grid.Location = new System.Drawing.Point(13, 13);
            this.pnl_grid.Name = "pnl_grid";
            this.pnl_grid.Size = new System.Drawing.Size(705, 633);
            this.pnl_grid.TabIndex = 8;
            this.pnl_grid.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_grid_Paint);
            // 
            // txt_vertices_name
            // 
            this.txt_vertices_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_vertices_name.Location = new System.Drawing.Point(62, 64);
            this.txt_vertices_name.Name = "txt_vertices_name";
            this.txt_vertices_name.Size = new System.Drawing.Size(82, 24);
            this.txt_vertices_name.TabIndex = 0;
            // 
            // lbl_vertices_name
            // 
            this.lbl_vertices_name.AutoSize = true;
            this.lbl_vertices_name.Location = new System.Drawing.Point(8, 67);
            this.lbl_vertices_name.Name = "lbl_vertices_name";
            this.lbl_vertices_name.Size = new System.Drawing.Size(52, 18);
            this.lbl_vertices_name.TabIndex = 8;
            this.lbl_vertices_name.Text = "Name:";
            // 
            // cmb_vetices_list
            // 
            this.cmb_vetices_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_vetices_list.FormattingEnabled = true;
            this.cmb_vetices_list.Location = new System.Drawing.Point(6, 30);
            this.cmb_vetices_list.Name = "cmb_vetices_list";
            this.cmb_vetices_list.Size = new System.Drawing.Size(138, 26);
            this.cmb_vetices_list.TabIndex = 0;
            this.cmb_vetices_list.SelectedIndexChanged += new System.EventHandler(this.cmb_vetices_list_SelectedIndexChanged);
            // 
            // btn_route_find
            // 
            this.btn_route_find.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_route_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_route_find.Location = new System.Drawing.Point(9, 148);
            this.btn_route_find.Name = "btn_route_find";
            this.btn_route_find.Size = new System.Drawing.Size(135, 24);
            this.btn_route_find.TabIndex = 4;
            this.btn_route_find.Text = "Find Fastest Route";
            this.btn_route_find.UseVisualStyleBackColor = true;
            this.btn_route_find.Click += new System.EventHandler(this.btn_route_find_Click);
            // 
            // cmb_route_from
            // 
            this.cmb_route_from.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_route_from.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_route_from.FormattingEnabled = true;
            this.cmb_route_from.Location = new System.Drawing.Point(6, 48);
            this.cmb_route_from.Name = "cmb_route_from";
            this.cmb_route_from.Size = new System.Drawing.Size(138, 26);
            this.cmb_route_from.TabIndex = 0;
            // 
            // grb_route
            // 
            this.grb_route.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_route.Controls.Add(this.lbl_route_to);
            this.grb_route.Controls.Add(this.lbl_route_from);
            this.grb_route.Controls.Add(this.cmb_route_to);
            this.grb_route.Controls.Add(this.cmb_route_from);
            this.grb_route.Controls.Add(this.btn_route_find);
            this.grb_route.Location = new System.Drawing.Point(724, 468);
            this.grb_route.Name = "grb_route";
            this.grb_route.Size = new System.Drawing.Size(154, 178);
            this.grb_route.TabIndex = 9;
            this.grb_route.TabStop = false;
            this.grb_route.Text = "Add to the grid";
            // 
            // cmb_route_to
            // 
            this.cmb_route_to.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_route_to.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_route_to.FormattingEnabled = true;
            this.cmb_route_to.Location = new System.Drawing.Point(6, 98);
            this.cmb_route_to.Name = "cmb_route_to";
            this.cmb_route_to.Size = new System.Drawing.Size(138, 26);
            this.cmb_route_to.TabIndex = 5;
            // 
            // lbl_route_from
            // 
            this.lbl_route_from.AutoSize = true;
            this.lbl_route_from.Location = new System.Drawing.Point(12, 27);
            this.lbl_route_from.Name = "lbl_route_from";
            this.lbl_route_from.Size = new System.Drawing.Size(48, 18);
            this.lbl_route_from.TabIndex = 9;
            this.lbl_route_from.Text = "From:";
            // 
            // lbl_route_to
            // 
            this.lbl_route_to.AutoSize = true;
            this.lbl_route_to.Location = new System.Drawing.Point(30, 77);
            this.lbl_route_to.Name = "lbl_route_to";
            this.lbl_route_to.Size = new System.Drawing.Size(30, 18);
            this.lbl_route_to.TabIndex = 10;
            this.lbl_route_to.Text = "To:";
            // 
            // Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 654);
            this.Controls.Add(this.grb_route);
            this.Controls.Add(this.pnl_grid);
            this.Controls.Add(this.grb_vertices);
            this.Controls.Add(this.grb_gridsize);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Grid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fastest Route";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grb_gridsize.ResumeLayout(false);
            this.grb_gridsize.PerformLayout();
            this.grb_vertices.ResumeLayout(false);
            this.grb_vertices.PerformLayout();
            this.grb_route.ResumeLayout(false);
            this.grb_route.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_gridsize;
        private System.Windows.Forms.Button btn_gridsize_set;
        private System.Windows.Forms.Label lbl_gridsize_pxwidth;
        private System.Windows.Forms.Label lbl_gridsize_pxheight;
        private System.Windows.Forms.TextBox txt_gridsize_width;
        private System.Windows.Forms.TextBox txt_gridsize_height;
        private System.Windows.Forms.Label lbl_gridsize_width;
        private System.Windows.Forms.Label lbl_gridsize_height;
        private System.Windows.Forms.GroupBox grb_vertices;
        private System.Windows.Forms.CheckedListBox chb_vertices_edges;
        private System.Windows.Forms.Button btn_vertices_add_update;
        private System.Windows.Forms.Label lbl_vertices_pxy;
        private System.Windows.Forms.Label lbl_vertices_pxx;
        private System.Windows.Forms.TextBox txt_vertices_y;
        private System.Windows.Forms.TextBox txt_vertices_x;
        private System.Windows.Forms.Label lbl_vertices_y;
        private System.Windows.Forms.Label lbl_vertices_x;
        private System.Windows.Forms.Panel pnl_grid;
        private System.Windows.Forms.TextBox txt_vertices_name;
        private System.Windows.Forms.Label lbl_vertices_name;
        private System.Windows.Forms.ComboBox cmb_vetices_list;
        private System.Windows.Forms.Button btn_route_find;
        private System.Windows.Forms.ComboBox cmb_route_from;
        private System.Windows.Forms.GroupBox grb_route;
        private System.Windows.Forms.Label lbl_route_to;
        private System.Windows.Forms.Label lbl_route_from;
        private System.Windows.Forms.ComboBox cmb_route_to;
    }
}

