using System;
using System.Collections.Generic;
using System.Linq;

namespace FastestRoute
{
    public class Graph
    {
        public Dictionary<string, Node> Matrix = new Dictionary<string, Node>();
        

        /// <summary>
        /// Retrives a Node object from the Matrix based on its name
        /// </summary>
        /// <param name="name">Matrix key</param>
        /// <returns></returns>
        public Node GetVertex(string name)
        {
            if (Matrix.ContainsKey(name))
                return Matrix[name];

            return null;
        }

        /// <summary>
        /// Add a new Node to the Matrix Dictionary
        /// </summary>
        /// <param name="vertex">Node to be added</param>
        public void AddVertex(Node vertex)
        {
            if (!Matrix.ContainsKey(vertex.Name))
                Matrix.Add(vertex.Name, vertex);
        }


        /// <summary>
        /// Adds a directional connection between two vertices. Source is connected to Destination but not the opposite
        /// </summary>
        public void AddEdge(Node vertexSource, Node vertexDestination)
        {
            if (Matrix.ContainsKey(vertexSource.Name) && Matrix.ContainsKey(vertexDestination.Name))
            {
                //Calculates the length of edge (distance betwee the two vertices)
                //this will be latter used to calculate the route distance
                vertexDestination.DistanceFromEdge = Node.CalculateDistance(vertexSource.X, vertexSource.Y, vertexDestination.X, vertexDestination.Y);
                vertexSource.Edges.AddFirst(vertexDestination);                
            }
        }

        /// <summary>
        /// Removes a previously added directional connection between two vertices
        /// </summary>
        public void RemoveEdge(Node vertexSource, Node vertexToRemove)
        {
            if (Matrix.ContainsKey(vertexSource.Name) && Matrix[vertexSource.Name].Edges.Find(vertexToRemove) != null)
                Matrix[vertexSource.Name].Edges.Remove(vertexToRemove);
        }

        /// <summary>
        /// Looks for all possible routes from start to target
        /// </summary>
        /// <returns>List of nodes representing the fastest route from start to target</returns>
        public List<Node> RouteSearch(Node start, Node target)
        {
            //list of lists representing all possible routes, this will be used for recursion
            List<List<Node>> routeList = new List<List<Node>>();

            //this is important to prevent an infinit loop where child vertices are connected to to it's parent
            HashSet<Node> alreadyLooked = new HashSet<Node>(); 

            alreadyLooked.Add(start);
            foreach (var node in start.Edges)
            {
                //creates a route with the start node 
                //and passes it with it's current child to the recursive method
                List<Node> route = new List<Node>();
                route.Add(start);

                //add the complete route to the routelist
                routeList.Add(DepthFirstSearch(node, target, routeList, route, alreadyLooked));
            }

            //this will store all routes where the target node is present and their distances
            Dictionary<List<Node>, double> performance = new Dictionary<List<Node>, double>();
            foreach(var route in routeList.Where(x => x.Contains(target)))
                performance.Add(route, route.Sum(x => x.DistanceFromEdge)); //add route and calculate distance


            //return the route with the smallest distance or null if there is no route
            return performance.OrderBy(x => x.Value).FirstOrDefault().Key; 
        }
        public List<Node> DepthFirstSearch(Node current, Node target, List<List<Node>> routes, List<Node> route, HashSet<Node> alreadyLooked)
        {
            //this is preventing an infinit loop where child vertices are connected to to it's parent
            if (alreadyLooked.Contains(current))            
                return route;

            //if it was not on the list, now it is 
            alreadyLooked.Add(current);
            route.Add(current); //add the curretn node to the route list

            if (current == target) //found my target
                return route;

            foreach (var node in current.Edges) //run through the child vertices and call the recursion
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
