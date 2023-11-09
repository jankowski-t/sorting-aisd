using System.Diagnostics;

namespace Sorting {
    public partial class Form1 : Form {
        private Random rnd = new Random();
        public Form1() {
            InitializeComponent();
        }

        private List<int> parseInput() {
            string[] numS = inputTB.Text.Trim().Split(null as char[], StringSplitOptions.RemoveEmptyEntries);
            List<int> numI = new List<int>(numS.Length);
            foreach(string s in numS) {
                int x;
                int.TryParse(s, out x);
                numI.Add(x);
            }
            return numI;
        }

        private List<int> parseOrGenerate() {
            List<int> numI;
            if(!inputCB.Checked) {
                int n = (int)genNUD.Value;
                numI = new List<int>(n);
                for(int i = 0; i < n; i++) {
                    numI.Add(rnd.Next());
                }
            }
            else {
                numI = parseInput();
            }
            return numI;
        }

        private void printResult(List<int> result, long time) {
            outputL.Text = "";
            timeValL.Text = "";
            if(inputCB.Checked) {
                foreach(int n in result) {
                    outputL.Text += n;
                    outputL.Text += ' ';
                }
            }
            timeValL.Text = (time.ToString() + " ms");
        }

        private void deactivateControls() {
            inputCB.Enabled = false;
            inputTB.Enabled = false;
            genNUD.Enabled = false;
            bsB.Enabled = false;
            ssB.Enabled = false;
            isB.Enabled = false;
            msB.Enabled = false;
            qsB.Enabled = false;
        }
        private void activateControls() {
            inputCB.Enabled = true;
            bsB.Enabled = true;
            ssB.Enabled = true;
            isB.Enabled = true;
            msB.Enabled = true;
            qsB.Enabled = true;
            if(inputCB.Checked == true) {
                inputTB.Enabled = true;
                genNUD.Enabled = false;
            }
            else {
                inputTB.Enabled = false;
                genNUD.Enabled = true;
            }
        }

        private void bsB_Click(object sender, EventArgs e) {
            deactivateControls();
            List<int> arr = parseOrGenerate();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for(int i = 0; i < (arr.Count - 1); i++) {
                for(int j = 0; j < (arr.Count - 1 - i); j++) {
                    if(arr[j] > arr[j + 1]) {
                        swapAt(arr, j, j + 1);
                    }
                }
            }

            stopwatch.Stop();
            printResult(arr, stopwatch.ElapsedMilliseconds);
            activateControls();
        }

        private void inputCB_CheckedChanged(object sender, EventArgs e) {
            if(inputCB.Checked) {
                genNUD.Enabled = false;
                inputTB.Enabled = true;
            }
            else {
                genNUD.Enabled = true;
                inputTB.Enabled = false;
            }
        }

        private void swapAt(List<int> arr, int i, int j) {
            int c = arr[j];
            arr[j] = arr[i];
            arr[i] = c;
        }

        private void ssB_Click(object sender, EventArgs e) {
            deactivateControls();
            List<int> arr = parseOrGenerate();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for(int i = 0; i < (arr.Count - 1); i++) {
                int jMin = i, j;
                for(j = (i + 1); j < arr.Count; j++) {
                    if(arr[j] < arr[jMin]) {
                        jMin = j;
                    }
                }
                if(jMin != i) {
                    swapAt(arr, i, jMin);
                }
            }

            stopwatch.Stop();
            printResult(arr, stopwatch.ElapsedMilliseconds);
            activateControls();
        }

        private void isB_Click(object sender, EventArgs e) {
            deactivateControls();
            List<int> arr = parseOrGenerate();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for(int i = 1; i < arr.Count; i++) {
                int x = arr[i];
                int j;
                for(j = (i - 1); (j >= 0) && (arr[j] > x); j--) {
                    arr[j + 1] = arr[j];
                }
                arr[j + 1] = x;
            }

            stopwatch.Stop();
            printResult(arr, stopwatch.ElapsedMilliseconds);
            activateControls();
        }

        private void merge(List<int> a, int i, int j, int k, List<int> b) {
            int x = i;
            int y = j;
            int z = i;
            while((x < j) && (y < k)) {
                if(b[x] < b[y]) {
                    a[z] = b[x];
                    x++;
                }
                else {
                    a[z] = b[y];
                    y++;
                }
                z++;
            }
            while(x < j) {
                a[z] = b[x];
                x++;
                z++;
            }
            while(y < k) {
                a[z] = b[y];
                y++;
                z++;
            }
        }

        private void mergeSort(List<int> a, int i, int j, List<int> b) {
            if((j - i) > 1) {
                int k = ((i + j) / 2);
                mergeSort(b, i, k, a);
                mergeSort(b, k, j, a);
                merge(a, i, k, j, b);

            }
        }

        private void msB_Click(object sender, EventArgs e) {
            deactivateControls();
            List<int> arr = parseOrGenerate();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var b = new List<int>(arr);
            mergeSort(arr, 0, arr.Count, b);

            stopwatch.Stop();
            printResult(arr, stopwatch.ElapsedMilliseconds);
            activateControls();
        }

        private int partition(List<int> a, int i, int j) {
            int pivot = a[j];
            int x = (i - 1);
            for(int y = i; y < j; y++) {
                if(a[y] <= pivot) {
                    x++;
                    swapAt(a, x, y);
                }
            }
            x++;
            swapAt(a, x, j);
            return x;
        }

        private void quicksort(List<int> a, int i, int j) {
            if((j > i) && (i >= 0)) {
                int p = partition(a, i, j);
                quicksort(a, i, p - 1);
                quicksort(a, p + 1, j);
            }
        }

        private void qsB_Click(object sender, EventArgs e) {
            deactivateControls();
            List<int> arr = parseOrGenerate();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            quicksort(arr, 0, arr.Count - 1);

            stopwatch.Stop();
            printResult(arr, stopwatch.ElapsedMilliseconds);
            activateControls();
        }
    }
}