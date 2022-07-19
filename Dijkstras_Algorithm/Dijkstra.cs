using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dijkstras_Algorithm
{
    public partial class Dijkstra : Form
    {

        //private Vector2D _sourceVector, _targetVector;

        Dictionary<int, Vector2D> resultIndexVertexMapping = new Dictionary<int, Vector2D>();

        public Dijkstra()
        {
            InitializeComponent();
        }


        private void btnAddvertex_Click(object sender, EventArgs e)
        {
            Vector2D newVertex = new Vector2D(0,
                0, false);

            lboVertexes.Items.Add(newVertex);
        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {

            Edge newEdge;

            for (int i = 0; i < lboVertexes.Items.Count; i++) {

                if (((Vector2D)lboVertexes.Items[i]).VertexID == Convert.ToInt32(txtFirstNodeID.Text))
                {
                    for (int j = 0; j < lboVertexes.Items.Count; j++)
                    {
                        if (((Vector2D)lboVertexes.Items[j]).VertexID == 
                            Convert.ToInt32(txtSecondNodeID.Text))
                        {
                            newEdge = new Edge((Vector2D)lboVertexes.Items[i], 
                                (Vector2D)lboVertexes.Items[j], Convert.ToInt32(txtLength.Text));

                            lboEdges.Items.Add(newEdge);
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void btnSetSource_Click(object sender, EventArgs e)
        {
            if (lboVertexes.SelectedItems.Count > 0)
            {
                Vector2D _sourceVector = (Vector2D)lboVertexes.SelectedItem;
                lblSource.Text = _sourceVector.VertexID.ToString();

                lblSource.Tag = _sourceVector;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Create a brand new graph, fill it with vertices and edges, and calculate the minimal path
            Graph graph = new Graph();

            // clear the listbox that contains a list of lowest cost paths
            lboLowestCostPath.Items.Clear();

            // Reset dictionary
            resultIndexVertexMapping.Clear();

            for (int i = 0; i < lboVertexes.Items.Count; i++)
            {
                graph.AddVertex((Vector2D) lboVertexes.Items[i]);
            }

            for (int i = 0; i < lboEdges.Items.Count; i++)
            {
                graph.AddEdge((Edge)lboEdges.Items[i]);
            }

            graph.SourceVertex = (Vector2D) lblSource.Tag;
            //graph.TargetVertex = (Vector2D) lblTarget.Tag;

            if (graph.CalculateShortestPath())
            {
                //txtTotalCost.Text = graph.TotalCost.ToString();
                string directionIndicator = " -> ";

                // Find the shortest path for every other node from the source node
                foreach (Vector2D targetNode in graph.AllNodes)
                {
                    // build the string for the optimal path
                    StringBuilder buildOptimalPathText = new StringBuilder();

                    foreach (Vector2D currentNode in graph.RetrieveShortestPath(targetNode))
                    {
                        // build up the path string
                        buildOptimalPathText.Append(currentNode.VertexID);
                        buildOptimalPathText.Append(directionIndicator);
                    }

                    // remove the extraneous direction indicator at the end of the string
                    buildOptimalPathText.Remove(buildOptimalPathText.Length - directionIndicator.Length,
                                directionIndicator.Length);

                    // display it and add the resulting index position of the new list item as a key 
                    // into the index to vertex mapping dictionary along with the targetnode.
                    resultIndexVertexMapping.Add(lboLowestCostPath.Items.Add(buildOptimalPathText.ToString()), targetNode); 
                }

                if (lboLowestCostPath.Items.Count > 0)
                {
                    // select the first element in the listbox as the default element
                    lboLowestCostPath.SelectedIndex = 0;

                    // set the totalcost of this path
                    txtTotalCost.Text = resultIndexVertexMapping[lboLowestCostPath.SelectedIndex].AggregateCost.ToString();
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string help = "1. Add as many vertices as you need. \n"
                + "2. Add as many edges as you need, make sure there is no deadend or orphan vertex. \n"
                + "3. Click to select a vertex in the list of vertices and click on Set as Source as the source node. \n"
                + "4. Click on Calculate to find the shortest path and the total cost from source vertex to every other vertex.";

            MessageBox.Show(help, "Help", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnDeleteVertex_Click(object sender, EventArgs e)
        {
            if (lboVertexes.SelectedItems.Count > 0)
            {
                lboVertexes.Items.RemoveAt(lboVertexes.SelectedIndex);
            }
        }

        private void btnDeleteEdge_Click(object sender, EventArgs e)
        {
            if (lboEdges.SelectedItems.Count > 0)
            {
                lboEdges.Items.RemoveAt(lboEdges.SelectedIndex);
            }
        }

        private void lboLowestCostPath_SelectedIndexChanged(object sender, EventArgs e)
        {

            // set the totalcost of the currently selected path
            txtTotalCost.Text = resultIndexVertexMapping[lboLowestCostPath.SelectedIndex].AggregateCost.ToString();
        }

    }
}
