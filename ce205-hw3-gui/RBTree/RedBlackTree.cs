using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Security.Cryptography;

namespace ce205_hw3_gui.RBTree
{
    public class RedBlackTree
    {
        /// <summary>
        /// The code contains a NodeAVL class that has a root node.The NodeAVL is the root of the tree,
        /// which means it's the first node in the list.The Line class is an example of how to create nodes in this AVL tree. 
        /// A LingkaranRB object represents each leaf of the AVL tree.
        /// </summary>
        public NodeAVL root;
        public List<line> garis = new List<line>();
        public List<LingkaranRB> lingkaran = new List<LingkaranRB>();


        int ctrGaris = 1;
        int ctrLingkaran = 1;
        Form1 parent;
        public RedBlackTree(Form1 parent)
        {
            root = null;
            this.parent = parent;
        }
        /// <summary>
        /// The code inserts a new node into the tree.
        /// The insertion method takes two parameters: root and key.
        /// The first parameter is the NodeAVL that will be inserted, which in this case is "root".
        /// The second parameter is the string value of the key to insert into the tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="key"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void insertion(ref NodeAVL root, string key, int x, int y)
        {
            /// The insertion function takes in two parameters: root and key. 
            /// The code first checks if the root is null,
            /// which means that it has not been created yet.
            NodeAVL newnode = new NodeAVL(key);
            if (root == null)
            {
                root = newnode;
                root.x = x;
                root.y = y;
                root.color = Color.Black;
                parent.pictureBox2.Invalidate();
            }
            else
            {
                NodeAVL current = root;
                while (true)
                {
                    if (string.Compare(key, current.value)<0)
                    {
                        if (current.left == null)
                        {
                            current.left = newnode;
                            newnode.parent = current;
                            retraceafterinsertion(ref root, newnode);
                            break;
                        }
                        current = current.left;
                    }
                    else
                    {
                        if (current.right == null)
                        {
                            current.right = newnode;
                            newnode.parent = current;
                            retraceafterinsertion(ref root, newnode);
                            break;
                        }
                        current = current.right;
                    }
                }
            }
            resetheight(ref root);
            lingkaran.Clear();
            updatelingkaran(ref root);
            garis.Clear();
            addgaris(ref root);
            parent.pictureBox2.Invalidate();
        }
        /// <summary>
        /// The code is meant to compare two integers and return the larger of the two.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int max(int a, int b)
        {
            return (a > b) ? a : b;
        }
        /// <summary>
        /// The code returns the smaller of two integers.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int min(int a, int b)
        {
            return (a < b) ? a : b;
        }
        /// <summary>
        /// The code swaps the colors of two nodes. The first if statement checks to see if the node's color is different from its neighbor's,
        /// and if so it changes the color of one of them. The swapcolor function swaps the colors between two nodes in a binary tree.
        /// It starts by checking that both nodes are not equal to themselves (if they were, then nothing would happen). 
        /// If they are not equal, then it sets their respective colors to each other and returns true.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        public void swapcolor(NodeAVL p, NodeAVL q)
        {
            if (p.color != q.color)
            {
                Color temp = p.color;
                p.color = q.color;
                q.color = temp;
            }
        }
        /// <summary>
        /// The code is a function that takes two parameters, the root node and p. The function first checks if p is null.
        /// If it's not, then the code goes on to check if p has a right child.
        /// If it does, then q is created and assigned to be the left child of p.Then q's parent becomes p, 
        /// which means that q will now have its own right child instead of being attached to its parent as before.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public NodeAVL singleLeftRotate(ref NodeAVL root, NodeAVL p)
        {
            if (p.right != null)
            {
                NodeAVL q = p.right;
                p.right = q.left;
                if (q.left != null)
                {
                    q.left.parent = p;
                }
                q.left = p;
                replacenodeinparent(ref root, p, q);
                p.parent = q;
                swapcolor(p, q);
                return q;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// The code is trying to find the left child of a node.
        /// If it finds one, then it will swap the color of that node with its right child and return the right child.
        /// Otherwise, if there is no left child, then it returns null.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public NodeAVL singleRightRotate(ref NodeAVL root, NodeAVL q)
        {
            if (q.left != null)
            {
                NodeAVL p = q.left;
                q.left = p.right;
                if (p.right != null)
                {
                    p.right.parent = q;
                }
                p.right = q;
                replacenodeinparent(ref root, q, p);
                q.parent = p;
                swapcolor(p, q);
                return q;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// the code is a function that takes in an AVL node and returns the color of the node.
        /// If the passed in node is null, then it will return black as its color.
        /// Otherwise, it will return the color of the passed in node.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public Color color(NodeAVL n)
        {
            if (n == null)
            {
                return Color.Black;
            }
            else
            {
                return n.color;
            }
        }
        /// <summary>
        /// The code begins by declaring a NodeAVL line and adding it to the root node.
        /// The code then loops through the while loop, which checks if current is equal to root.
        /// If so, current's color is changed to black and its parent becomes red.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="current"></param>
        public void retraceafterinsertion(ref NodeAVL root, NodeAVL current)
        {
            garis.Clear();
            addgaris(ref root);
            while (true)
            {
                if (current == root)
                {
                    current.color = Color.Black;
                    break;
                }
                if (current.parent.color == Color.Red)
                {
                    NodeAVL p = current.parent;
                    NodeAVL g = p.parent;
                    NodeAVL u = p == g.left ? g.right : g.left;
                    if (color(u) == Color.Red)
                    {
                        p.color = Color.Black;
                        u.color = Color.Black;
                        g.color = Color.Red;
                        current = g;
                    }
                    else
                    {
                        rotate(ref root, current, p, g);
                        break;
                    }
                }
                else break;
            }
            lingkaran.Clear();
            updatelingkaran(ref root);
            parent.pictureBox2.Invalidate();
        }
        /// <summary>
        /// The code rotates the root node, which is a NodeAVL object, by one step to the right or left.
        /// If it's on its own side of the tree and there is no other node in that direction, then it will rotate back around to where it started.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="r"></param>
        /// <param name="p"></param>
        /// <param name="g"></param>
        /// <returns></returns>
        public NodeAVL rotate(ref NodeAVL root, NodeAVL r, NodeAVL p, NodeAVL g)
        {
            if (p == g.left && (r == null || r == p.left))
            {
                singleRightRotate(ref root, g);
                return r;
            }
            else if (p == g.left && r == p.right)
            {
                singleLeftRotate(ref root, g.left);
                singleRightRotate(ref root, g);
                return p;
            }
            else if (p == g.right && (r == p.right || r == null))
            {
                singleLeftRotate(ref root, g);
                return r;
            }
            else if (p == g.right && r == p.left)
            {
                singleRightRotate(ref root, g.right);
                singleLeftRotate(ref root, g);
                return p;
            }
            return null;

        }

        public void doubleLeftRotate(ref NodeAVL root, NodeAVL q)
        {
            singleRightRotate(ref root, q.right);
            singleLeftRotate(ref root, q);
        }

        public void doubleRightRotate(ref NodeAVL root, NodeAVL q)
        {
            singleLeftRotate(ref root, q.left);
            singleRightRotate(ref root, q);
        }
        /// <summary>
        /// The code begins by checking if the root node is null.
        /// If it is, then the code calls resetheight on both its left and right children.
        /// The height of the root node will be set to 1, and then resetheight will be called again on its right child.
        /// </summary>
        /// <param name="root"></param>
        public void resetheight(ref NodeAVL root)
        {
            if (root != null)
            {
                resetheight(ref root.left);
                root.height = 1;
                resetheight(ref root.right);
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// The code starts by adding a new node to the root of the AVL tree.
        /// The code then checks if there is already a parent for this node, and if not, it creates one.
        /// Adjusts the height
        /// </summary>
        /// <param name="root"></param>
        public void addlingkaran(ref NodeAVL root)
        {
            if (root.parent != null)
            {
                if (!root.isRight)
                {
                    root.x = root.parent.x - 300 / root.height;
                    root.y = root.parent.y + 50;
                }
                else
                {
                    root.x = root.parent.x + 300 / root.height;
                    root.y = root.parent.y + 50;
                }
            }
            if (this.root == root)
            {
                this.root.x = root.x;
                this.root.y = root.y;
            }
            if (root.passed)
            {
                lingkaran.Add(new LingkaranRB(root.x, root.y, root.value.ToString(), Color.Yellow));
            }
            else
            {
                lingkaran.Add(new LingkaranRB(root.x, root.y, root.value.ToString(), root.color));
            }
        }
        /// <summary>
        /// The code is used to update the value of a node in an AVL tree.
        /// The code starts by checking if the root node exists, if it does then it will print out the current value of that node and then check if there are any left or right child nodes.
        /// If so, it will call another function called updatelingkaran which updates those nodes and then calls addlingkaran which adds a new node.
        /// </summary>
        /// <param name="root"></param>
        public void updatelingkaran(ref NodeAVL root)
        {
            if (root != null)
            {
                Console.WriteLine(root.value + "_" + root.height);
                if (root.left != null)
                {
                    root.left.parent = root;
                    root.left.isRight = false;
                    root.left.height = (root.height + 1);
                }
                updatelingkaran(ref root.left);
                addlingkaran(ref root);
                if (root.right != null)
                {
                    root.right.parent = root;
                    root.right.isRight = true;
                    root.right.height = (root.height + 1);
                }
                updatelingkaran(ref root.right);
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// The code starts by adding a new line to the end of the list.
        /// The next part of the code checks if there is an empty space in between each node on the list.
        /// If so, it adds another line with a yellow background color at 15 pixels from one side of the current node and 15 pixels from its opposite side.
        /// </summary>
        /// <param name="root"></param>
        public void addgaris(ref NodeAVL root)
        {
            
            if (root != null)
            {
                if (root.left != null)
                {
                    if (root.left.passed && root.passed)
                    {
                        garis.Add(new line(root.x + 15, root.y + 15, root.left.x + 15, root.left.y + 15, Color.Yellow));
                    }
                    else
                    {
                        garis.Add(new line(root.x + 15, root.y + 15, root.left.x + 15, root.left.y + 15, Color.Black));
                    }
                }
                addgaris(ref root.left);
                if (root.right != null)
                {
                    if (root.right.passed && root.passed)
                    {
                        garis.Add(new line(root.x + 15, root.y + 15, root.right.x + 15, root.right.y + 15, Color.Yellow));
                    }
                    else
                    {
                        garis.Add(new line(root.x + 15, root.y + 15, root.right.x + 15, root.right.y + 15, Color.Black));
                    }
                }
                addgaris(ref root.right);
            }
            else
            {
                return;
            }
        }

        public Color nodecolor(NodeAVL node)
        {
            return node.color == Color.Black ? Color.Black : node.color;
        }
        /// <summary>
        /// The code is used to replace the node in its parent with a new child.
        /// If the current node has no parent, then it will be replaced by the new child that was passed into this function.
        /// If the current node does have a parent, then it will be replaced by its parent's left and right children if they exis
        /// </summary>
        /// <param name="root"></param>
        /// <param name="node"></param>
        /// <param name="child"></param>
        public void replacenodeinparent(ref NodeAVL root, NodeAVL node, NodeAVL child)
        {
            if (node.parent == null)
            {
                root = child;
            }
            else if (node.parent.left == node)
            {
                node.parent.left = child;
            }
            else
            {
                node.parent.right = child;
            }
            if (child != null)
            {
                child.parent = node.parent;
            }
        }
        /// <summary>
        /// The code is a recursive function that can be used to find the root node of an AVL tree.
        /// The NodeAVL class implements the functionality of the AVL tree and provides methods for finding the left and right child nodes.
        /// The code above uses recursion, which means it calls itself repeatedly until it finds a node with a value less than or equal to 0.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public NodeAVL find(NodeAVL root, string value)
        {
            NodeAVL current = root;
            while (current != null && value != current.value)
            {
                if (string.Compare (value ,current.value)<0)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }
            }
            return current;
        }
        /// <summary>
        /// The code above starts by finding the root node and then checks if it is null or not.
        /// If it is not null, then it will find the predecessor node of that node and while there are nodes left to be deleted,
        /// they will be deleted one by one from the parent until there is only one left which will have its value set to 0 and finally replaced in the parent.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        public void delete(ref NodeAVL root, string value)
        {
            NodeAVL current = find(root, value);
            if (current != null)
            {
                if (current.left == null || current.right == null)
                {
                    replaceNodeInParentAndBalancing(ref root, current, current.left == null ? current.right : current.left);
                }
                else
                {
                    NodeAVL predecessor = current.left;
                    while (predecessor.right != null)
                    {
                        predecessor = predecessor.right;
                    }
                    current.value = predecessor.value;
                    replaceNodeInParentAndBalancing(ref root, predecessor, predecessor.left);
                }
                garis.Clear();
                addgaris(ref root);
                lingkaran.Clear();
                updatelingkaran(ref root);
                parent.pictureBox2.Invalidate();
            }
        }
        public void search(ref NodeAVL root, string value)
        {
            searching(ref root, value);
            lingkaran.Clear();
            updatelingkaran(ref root);
            garis.Clear();
            addgaris(ref root);
            parent.pictureBox2.Invalidate();
            resetsearch(ref root, value);
        }
        /// <summary>
        /// The code is searching for a node in the AVL tree.
        /// The function starts by creating an empty NodeAVL object called current and then loops through all of the nodes in the tree until it finds one that matches the value passed to it.
        /// If there is no match, then current will be set to null and passed as true.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public NodeAVL searching(ref NodeAVL root, string value)
        {
            NodeAVL current = root;
            while (current != null && value != current.value)
            {
                if (string.Compare(value, current.value)<0)
                {
                    current.passed = true;
                    current = current.left;
                }
                else
                {
                    current.passed = true;
                    current = current.right;
                }
            }
            current.passed = true;
            return current;
        }
        /// <summary>
        ///  The code starts by creating a NodeAVL root node.
        /// The code then iterates through the nodes of the tree, checking if they are null and comparing their value to the current value.
        /// If it is not equal, then that means that there is another node with a different value in between them.
        /// The code is a method that resets the search for the root node to a string value.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        public void resetsearch(ref NodeAVL root, string value)
        {
            NodeAVL current = root;
            while (current != null && value != current.value)
            {
                if (string.Compare(value ,current.value)<0)
                {
                    current.passed = false;
                    current = current.left;
                }
                else
                {
                    current.passed = false;
                    current = current.right;
                }
            }
            current.passed = false;
        }

        /// <summary>
        /// The code is trying to replace the node in its parent and balancing it.
        /// If the color of the child is red, then if there is a child, then change its color to black.
        /// Otherwise, if the color of the child is black and that of its parent is also black, then change their colors so they are gray.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="node"></param>
        /// <param name="child"></param>
        public void replaceNodeInParentAndBalancing(ref NodeAVL root, NodeAVL node, NodeAVL child)
        {
            if (node.color == Color.Red || color(child) == Color.Red)
            {
                if (child != null)
                {
                    child.color = Color.Black;
                }
            }
            else if (node.color == Color.Black && color(child) == Color.Black)
            {
                if (child == null)
                {
                    child = new NodeAVL();
                }
                else
                {
                    child.color = Color.Gray;
                }
            }
            replacenodeinparent(ref root, node, child);
            if (child != null)
            {
                retraceafterdeletion(ref root, child);
            }
        }
        /// <summary>
        /// The code decreases the color of a node by one step if it is gray.
        /// If the node is black, then its color will be red.
        /// The code decreases the color of a node by one step if it is gray.
        /// If the node is black, then its color will be red.
        /// The code decreases the color of a node by one step if it is gray, and increases the color by one step if it is black.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="node"></param>
        public void decreaseColor(ref NodeAVL root, NodeAVL node)
        {
            if (node.color == Color.Gray)
            {
                if (node.sentinel)
                {
                    if (node.parent == null) root = null;
                    else if (node.parent.left == node) node.parent.left = null;
                    else node.parent.right = null;
                }
                else node.color = Color.Black;
            }
            else if (node.color == Color.Black) node.color = Color.Red;
        }
        /// <summary>
        ///  The code increases the color of a node to black if it is red and gray if it is black.
        /// The code increases the color of a node to black if it is red and gray if it is black.
        /// The code increases the color of a node to black if it is currently red, or gray if it is currently black.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="node"></param>
        public void increaseColor(ref NodeAVL root, NodeAVL node)
        {
            if (node.color == Color.Red) node.color = Color.Black;
            else if (node.color == Color.Black) node.color = Color.Gray;
        }

        public void retraceafterdeletion(ref NodeAVL root, NodeAVL u)
        {
            while (u.color == Color.Gray)
            {
                if (u == root)
                {
                    decreaseColor(ref root, u);
                    break;
                }
                NodeAVL p = u.parent;
                NodeAVL s;
                if (u == p.left)
                {
                    s = p.right;
                }
                else
                {
                    s = p.left;
                }
                if (color(s) == Color.Red)
                {
                    rotate(ref root, null, s, p);
                }
                else
                {
                    NodeAVL r = null;
                    if (s == p.left)
                    {
                        if (color(s.left) == Color.Red) r = s.left;
                        else if (color(s.right) == Color.Red) r = s.right;
                    }
                    else
                    {
                        if (color(s.right) == Color.Red) r = s.right;
                        else if (color(s.left) == Color.Red) r = s.left;
                    }
                    if (r != null)
                    {
                        r = rotate(ref root, r, s, p);
                        increaseColor(ref root, r);
                        decreaseColor(ref root, u);
                        break;
                    }
                    else
                    {
                        decreaseColor(ref root, u);
                        decreaseColor(ref root, s);
                        increaseColor(ref root, p);
                        u = p;
                    }
                }
            }
        }
    }
}
