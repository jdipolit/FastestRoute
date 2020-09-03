using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FastestRoute
{
    public class Graph
    {
        public Dictionary<string, Node> Matrix = new Dictionary<string, Node>();
        
        public Node GetVertex(string name)
        {
            if (Matrix.ContainsKey(name))
                return Matrix[name];

            return null;
        }
        public void AddVertex(Node vertex)
        {
            if (!Matrix.ContainsKey(vertex.Name))
                Matrix.Add(vertex.Name, vertex);
        }

        public void RemoveVertex(string name)
        {
            if (Matrix.ContainsKey(name))
                Matrix.Remove(name);
        }

        public void AddEdge(Node vertexSource, Node vertexDestination)
        {
            if (Matrix.ContainsKey(vertexSource.Name) && Matrix.ContainsKey(vertexDestination.Name))
            {
                vertexDestination.DistanceFromEdge = Node.CalculateDistance(vertexSource.X, vertexSource.Y, vertexDestination.X, vertexDestination.Y);
                vertexSource.Edges.AddFirst(vertexDestination);                
            }
        }

        public void RemoveEdge(Node vertexSource, Node vertexToRemove)
        {
            if (Matrix.ContainsKey(vertexSource.Name) && Matrix[vertexSource.Name].Edges.Find(vertexToRemove) != null)
                Matrix[vertexSource.Name].Edges.Remove(vertexToRemove);
        }

        public List<Node> DepthFirstSearch(Node start, Node target)
        {
            List<List<Node>> routes = new List<List<Node>>();
            HashSet<Node> alreadyLooked = new HashSet<Node>();

            List<Node> route = new List<Node>();
            route.Add(start);

            alreadyLooked.Add(start);
            foreach (var node in start.Edges)
            {
                List<Node> newRoute = new List<Node>(route);
                routes.Add(DepthFirstSearch(node, target, routes, newRoute, alreadyLooked));
            }

            Dictionary<List<Node>, double> performance = new Dictionary<List<Node>, double>();
            foreach(var r in routes)
            {
                if (r[r.Count-1] == target) //se o ultimo elemento da lista for o targuet
                {
                    performance.Add(r, r.Sum(x => x.DistanceFromEdge));
                }                    
            }

            return performance.OrderBy(x => x.Value).FirstOrDefault().Key;
        }
        public List<Node> DepthFirstSearch(Node current, Node target, List<List<Node>> routes, List<Node> route, HashSet<Node> alreadyLooked)
        {
            if (alreadyLooked.Contains(current))            
                return route;

            alreadyLooked.Add(current);
            route.Add(current);

            if (current.Edges.Find(target) != null) //found it!
            {
                route.Add(target);
                return route;
            }
            else if (current == target)
                return route;

            foreach (var node in current.Edges)
            {
                List<Node> newRoute = new List<Node>(route);
                routes.Add(DepthFirstSearch(node, target, routes, newRoute, alreadyLooked));
            }

            return route;
        }
    }

    public class Node
    {
        public string Name;
        public int X;
        public int Y;
        public double DistanceFromEdge;
        public LinkedList<Node> Edges = new LinkedList<Node>();

        public Node(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
            DistanceFromEdge = 0;
        }

        public static double CalculateDistance(int x1, int y1, int x2, int y2)
        {
            //√((x_2-x_1)²+(y_2-y_1)²)
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));            
        }
    }
}
