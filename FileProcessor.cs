using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace RunbeckProcessFile
{
    public enum FileType { CSV, TSV }

    public class FileProcessor
    {
        public string FilePath { get;  private set; }
        public FileType FileType { get; private set; }
        public int FieldsCount { get; private set; }
        public int TotalRecordsCount { get; private set; }
        public int ValidRecordsCount { get; private set; }
        public int InvalidRecordsCount { get; private set; }

        public FileProcessor(string filePath, FileType fileType, int fieldsCount)
        {
            FilePath = filePath;
            FileType = fileType;
            FieldsCount = fieldsCount;
        }
             
        public void ProcessFile()
        {
            var delimiter = (char)(FileType == FileType.CSV ? ',' : '\t');

            var validRecords = new List<string>();
            var invalidRecords = new List<string>();

            try
            {
                string[] lines = File.ReadAllLines(FilePath);
                lines = lines.Skip(1).ToArray();
                TotalRecordsCount = lines.Length;

                // process all lines in parallel
                Parallel.ForEach(lines, (line, _, lineNumber) =>
                {
                    if (line.Split(delimiter).Length == FieldsCount)
                    {
                        lock (validRecords)
                        {
                            validRecords.Add(line);
                        }
                    }
                    else
                    {
                        lock (invalidRecords)
                        {
                            invalidRecords.Add(line);
                        }
                    }
                });

                // create valid records file
                if (validRecords.Count > 0)
                {
                    File.WriteAllLines("ValidRecords.txt", validRecords.ToArray());
                }

                // create invalid record file
                if (invalidRecords.Count > 0)
                {
                    File.WriteAllLines("InvalidRecords.txt", invalidRecords.ToArray());
                }

                ValidRecordsCount = validRecords.Count;
                InvalidRecordsCount = invalidRecords.Count;
                validRecords.Clear();
                invalidRecords.Clear();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
