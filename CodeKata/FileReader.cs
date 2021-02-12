using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodeKata {
    public class FileReader {

        // http://codekata.com/kata/kata04-data-munging/

        private static string weatherPath = "Data/weather.dat";
        private static string footballPath = "Data/football.dat";

        RealIOSystem io = new RealIOSystem();
        List<string[]> days = new List<string[]>();

        public List<string[]> ReadFileUsingSubString() {

            var file = File.ReadAllLines(weatherPath);

            foreach (var line in file) {
                // 4, 7, 7, 6, 7, 5, 5, 6, 7, 5, 5, 4, 4, 5, 4, 3, 6
                var field01 = line.Substring(0, 4);
                var field02 = line.Substring(4, 7);
                var field03 = line.Substring(13, 7);
                // Don't need this column onwards.  This is just for learning.   
                
                // I realize ReadAllLines wouldn't be good for really large files and that
                // reading a file line by line or streaming part of the file would be 
                // better for performance.

                var field04 = line.Substring(20, 6);
                var field05 = line.Substring(26, 7);
                var field06 = line.Substring(33, 5);
                var field07 = line.Substring(38, 5);
                var field08 = line.Substring(43, 6);
                // Reading a lot of columns with Substring is really tedious. 
                var field09 = line.Substring(49, 7);
                var field10 = line.Substring(56, 5);
                var field4 = line.Substring(20, 5);
                var field4 = line.Substring(20, 4);
                var field4 = line.Substring(20, 4);
                var field4 = line.Substring(20, 5);
                var field4 = line.Substring(20, 4);
                var field4 = line.Substring(20, 3);
                var field4 = line.Substring(20, 6);
            }

            return days;
        }

        public List<string[]> ReadFileUsingTextFileParser() {
            using (var reader = new TextFieldParser(weatherPath)) {

                reader.TextFieldType = FieldType.FixedWidth;
                reader.SetFieldWidths(4, 7, 7, 6, 7, 5, 5, 6, 7, 5, 5, 4, 4, 5, 4, 3, 6);

                try {
                    while (!reader.EndOfData) {
                        var currentRow = reader.ReadFields();

                        var arr = new[] { currentRow[0], currentRow[2], currentRow[1] };

                        days.Add(arr);
                    }
                }
                catch (Exception e) {
                    io.WriteOutput(e.StackTrace);
                }

            }

            return days;
        }

        public void FindSmallestTemperatureSpread(List<String> data) {

            var arr = new int[data.Count];

            for (var i = 0; i < data.Count; i++) {

            }
        }
    }
}
