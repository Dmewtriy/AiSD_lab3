using ScottPlot;
using System.Security.Cryptography;
using lab3;

namespace Graphs
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
            RunBenchmark();
        }

        private void RunBenchmark()
        {
            int step = 1000;
            int size = step;
            int count = 20;

            List<double> xData = new List<double>();
            List<double> selectionTimes = new List<double>();
            List<double> quickTimes = new List<double>();
            List<double> heapTimes = new List<double>();
            List<double> radixTimes = new List<double>();
            List<double> insertionTimes = new List<double>();

            formsPlot1.Plot.Clear();

            for (int i = 0; i < count; i++)
            {
                size = (i + 1) * step;
                xData.Add(size);

                int[] baseArray = ArrayGenerator.GenerateRandomSequence(size);
                SortAlgorithms alg = new SortAlgorithms(baseArray);

                selectionTimes.Add(alg.SelectionSort().Item2);
                quickTimes.Add(alg.QuickSort().Item2);
                heapTimes.Add(alg.HeapSort().Item2);
                radixTimes.Add(alg.RadixSort().Item2);
                insertionTimes.Add(alg.InsertionSort().Item2);
            }

            DrawLine(xData, selectionTimes, "Selection Sort");
            DrawLine(xData, insertionTimes, "Insertion Sort");
            DrawLine(xData, quickTimes, "Quick Sort");
            DrawLine(xData, heapTimes, "Heap Sort");
            DrawLine(xData, radixTimes, "Radix Sort");
        }

        private void DrawLine(List<double> xData, List<double> yData, string label)
        {
            var scatter = formsPlot1.Plot.Add.Scatter(xData.ToArray(), yData.ToArray());
            scatter.Label = label;

            formsPlot1.Plot.ShowLegend();
            formsPlot1.Plot.Legend.Alignment = Alignment.UpperLeft;
            formsPlot1.Plot.Axes.AutoScale();

            var lim = formsPlot1.Plot.Axes.GetLimits();
            formsPlot1.Plot.Axes.SetLimits(0, lim.Right, 0, lim.Top);
            formsPlot1.Plot.Axes.Bottom.Label.Text = "Размер строки (n)";
            formsPlot1.Plot.Axes.Left.Label.Text = "Время построения (мс)";
            formsPlot1.Refresh();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string list = txtInput.Text;

            string[] arr_split = list.Split(',');
            int val;
            int[] arr = new int[arr_split.Length];
            int i = 0;
            foreach (var item in arr_split)
            {
                if (!int.TryParse(item, out val))
                {
                    return;
                }
                arr[i] = val; 
                i++;
            }
            SortAlgorithms algorithm = new SortAlgorithms(arr);

            (int[] sort_arr, double time) = algorithm.SelectionSort();
            rtbSelection.Text = arrayToString(sort_arr);

            (sort_arr, time) = algorithm.QuickSort();
            rtbQuick.Text = arrayToString(sort_arr);

            (sort_arr, time) = algorithm.HeapSort();
            rtbHeap.Text = arrayToString(sort_arr);

            (sort_arr, time) = algorithm.RadixSort();
            rtbRadix.Text = arrayToString(sort_arr);

            (sort_arr, time) = algorithm.InsertionSort();
            rtbInsertion.Text = arrayToString(sort_arr);
        }

        private string arrayToString(int[] arr)
        {
            string res = "";
            foreach (var item in arr)
            {
                res += item.ToString() + ", ";
            }

            return res;
        }
    }
}
