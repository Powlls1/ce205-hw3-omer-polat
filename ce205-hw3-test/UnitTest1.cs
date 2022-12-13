using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce205_hw3_algo_lib;

namespace ce205_hw3_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HashingwithOpenAddressingLinearProbingTest()
        {
            OpenAddressing hash = new OpenAddressing(100);
            int n = 5;
            hash.OpenAddressingLinearProbingInsert(4, "faucibus", n);
            hash.OpenAddressingLinearProbingInsert(0, "semper augue", n);
            hash.OpenAddressingLinearProbingInsert(2, "id scelerisque neque", n);
            hash.OpenAddressingLinearProbingInsert(5, "Nunc faucibus metus", n);

            Assert.AreEqual("Nunc faucibus metus", hash.table[1].data);
        }
        [TestMethod]
        public void HashingwithOpenAddressingQuadraticProbingTest()
        {
            OpenAddressing hash = new OpenAddressing(100);
            int n = 6;
            hash.OpenAddressingQuadraticProbingInsert(10, "Sed mattis, tortor.", n);
            hash.OpenAddressingQuadraticProbingInsert(33, "velit lacus", n);
            hash.OpenAddressingQuadraticProbingInsert(4, "id scelerisque neque", n);
            hash.OpenAddressingQuadraticProbingInsert(600, "lectus nunc", n);
            hash.OpenAddressingQuadraticProbingInsert(48, "Phasellus eget", n);
            hash.OpenAddressingQuadraticProbingInsert(14, "molestie.", n);

            Assert.AreEqual("Phasellus eget", hash.table[1].data);
        }
        [TestMethod]
        public void HashingwithOpenAddressingDoubleProbingTest()
        {
            OpenAddressing hash = new OpenAddressing(100);
            int n = 7;
            hash.OpenAddressingDoubleProbingInsert(26, "malesuada", n);
            hash.OpenAddressingDoubleProbingInsert(65, "vulputate quis", n);
            hash.OpenAddressingDoubleProbingInsert(40, "Aenean rutrum", n);
            hash.OpenAddressingDoubleProbingInsert(14, "rhoncus", n);


            Assert.AreEqual("vulputate quis", hash.table[2].data);
        }


        /// <summary>
        /// HASHINGWITHCHAINING
        /// </summary>
        //[TestMethod]
        //public void HashingwithChainingInsert()
        //{
        //    HashingChaining hash = new HashingChaining(100);
        //    int n = 7;
        //    hash.HashingChainingLinearProbingInsert(1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", n);
        //    hash.HashingChainingLinearProbingInsert(2, "Aenean nec metus porta, feugiat quam ac, aliquet diam.",n);
        //    hash.HashingChainingLinearProbingInsert(3, "Vivamus eu odio sed lacus tincidunt mattis quis sed urna.", n);
        //    hash.HashingChainingLinearProbingInsert(4, "Duis sit amet odio et enim blandit mollis in vel dui.", n);

        //    Assert.AreEqual("Duis sit amet odio et enim blandit mollis in vel dui.", hash.table[4].First.Value.data);
        //}
        


        /// <summary>
        /// AVL TREE
        /// </summary>

        [TestMethod]
        public void AVLTreeInsertion()
        {
            AVLTree tree = new AVLTree();
            tree.insert(1, "Proin semper");
            tree.insert(2, "pharetra eros sagittis");
            tree.insert(3, "Aliquam");
            // tree.Insert(4, "Duis sit amet");

            Assert.AreEqual("pharetra eros sagittis", tree.root.data);
        }
        [TestMethod]
        public void AVLTreeDeletion()
        {
            AVLTree tree = new AVLTree();
            tree.insert(1, "Vivamus vulputate auctor");
            tree.insert(2, "mattis eros quis.");
            tree.insert(3, "dignissim tincidunt");
            tree.delete(2);

            Assert.AreEqual(0, tree.search(2));
        }
        [TestMethod]
        public void AVLTreeSearch()
        {
            AVLTree tree = new AVLTree();
            tree.insert(1, "vulputate auctor.");
            tree.insert(2, "Nunc faucibus metus");
            tree.insert(3, "Lorem ipsum");
            

            Assert.AreEqual(1, tree.search(1));
        }



        /// <summary>
        /// Red Black TREE
        /// </summary>

        [TestMethod]
        public void RedBlackTreeInsertion()
        {
            RedBlackTree tree = new RedBlackTree();
            tree.Insert(1, "id scelerisque neque");
            tree.Insert(2, "malesuada");
            tree.Insert(3, "Aenean rutrum");

            Assert.AreEqual("malesuada", tree.root.data);
        }
        [TestMethod]
        public void RedBlackTreeDeletion()
        {
            RedBlackTree tree = new RedBlackTree();
            tree.Insert(1, "fermentum lorem");
            tree.Insert(2, "mattis eros quis.");
            tree.Insert(3, "Pellentesque dignissim");
            tree.Delete(2);

            Assert.AreEqual("fermentum lorem", tree.root.left.data);
        }
        [TestMethod]
        public void RedBlackTreeSearch()
        {
            RedBlackTree tree = new RedBlackTree();
            tree.Insert(1, "semper augue");
            tree.Insert(2, "Sed mattis, tortor.");
            tree.Insert(3, "Phasellus eget");

            Assert.AreEqual(0, tree.Search(1));
        }

    }
}
