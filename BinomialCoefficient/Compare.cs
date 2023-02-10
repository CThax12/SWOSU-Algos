    using System;

    class Compare {

    public static void Main(string[] args) { 
            
            double[] dcTimes = new double[10];
            double[] dpTimes = new double[10];

            

            //time how long Divide and Conquer takes
            for (int i = 0; i < 10; ++i) {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            dcCalculate();
            watch.Stop();
            
            dcTimes[i] = watch.Elapsed.TotalMilliseconds;

            }

            //time how long Dynamic Programming takes
            for (int i = 0; i < 10; ++i) {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            dpCalculate();
            watch.Stop();
            dpTimes[i] = watch.Elapsed.TotalMilliseconds;
            }
            getdcAvgTime(dcTimes);
            getdpAvgTime(dpTimes);   
            }

           



        public static void dcCalculate() {
            Recursion dc = new Recursion();
            dc.test();
        }

        public static void dpCalculate() {
            DP dp = new DP();
            dp.test();
        }

        public static void getdcAvgTime(double[] times) {
            double sum = 0.0;

            foreach (double time in times) {
                sum += time;
            }

            double average = sum/10;
            double highest = times.Max();
            Console.WriteLine("\n\nAverage Divide and Conquer time in ms: " + average);
            Console.WriteLine("\nLongest Divide and Conquer time in ms: " + highest);


        }

        public static void getdpAvgTime(double[] times) {
            double sum = 0.0;

            foreach (double time in times) {
                sum += time;
            }

            double average = sum/10;
            double highest = times.Max();
            Console.WriteLine("\n\nAverage Dynamic Programming time in ms: " + average);
            Console.WriteLine("\nLongest Dynamic Programming time in ms: " + highest);

        }
    

    }
