﻿using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Formats.Asn1;

namespace boss
{
    static class FileWork
    {
        public static List<T> Deserialization<T>(string path)
        {
            List<T> list = new List<T>();

            using (var reader = new StreamReader(path))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<T>();

                    list = records.ToList();
                }
            }

            return list;
        }

        public static void Serialization<T>(List<T> list, string path)
        {
            using var writer = new StreamWriter(path);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(list);
        }
    }
}
