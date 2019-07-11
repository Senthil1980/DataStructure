using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructureCoding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //  int[] arr = { 5, 0, 1, 2, 6, 7 };
            //  SmallestMissingNumber _sm = new SmallestMissingNumber();
            //  int s = _sm.findFirstMissing(arr, 0, arr.Length-1);
            //lblText.Text = s.ToString();
            // PrimeNumber _pm = new PrimeNumber();
            //FindMissingNumber _fm = new FindMissingNumber();
            // _fm.Mainmethod();
            //Palindrome _pm = new Palindrome();
            // _pm.Palindrome1("madam");
            //SmallestPositiveIntegerMissingNumber _Spim = new SmallestPositiveIntegerMissingNumber();
            // _Spim.MainMethod();
            //FindAllMissingNumbers _fm = new FindAllMissingNumbers();
            // FindDuplicateNumbers _fm = new FindDuplicateNumbers();
            // _fm.MainMethod();
           // TwoSum _twosum = new TwoSum();
          //  int[] nums = { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 };
           // var temp = _twosum.TwoSumFunc(nums, 13);

            //ValidParenthesis _validParanthesis = new ValidParenthesis();
            //String s = "((()(())))";
            // var isVal =_validParanthesis.IsValid(s);

            // BestTimeBuySellStock _by = new BestTimeBuySellStock();
            //int[] nums = {2, 7, 3, 1};
            //var a = _by.MaxProfit(nums);

            //MergeTwoSortedLists _mg = new MergeTwoSortedLists();
            //var l1 = new ListNode(1);
            //var l2 = new ListNode(1);        
            //var l4 = new ListNode(3);      
            //l1.next = l2;       

            //var node = _mg.AddTwoNumbers(l1, l4);
            //while (node != null)
            //{
            //    Console.WriteLine(node.val);
            //    node = node.next;
            //}

            MergeTwoBinaryTrees _mtb = new MergeTwoBinaryTrees();
            TreeNode tree1 = new TreeNode(1);
            tree1.left = new TreeNode(3);
            tree1.left = new TreeNode(5);
            tree1.right = new TreeNode(2);
            int[] _node = tree1.;

            TreeNode tree2 = new TreeNode(2);
            tree1.left = new TreeNode(1);
            tree1.left = new TreeNode(4);
            tree1.right = new TreeNode(3);
            tree1.right = new TreeNode(7);


           var t =  _mtb.MergeTrees(tree1, tree2);
            //Console.ReadKey();
        }
        
    }
}
