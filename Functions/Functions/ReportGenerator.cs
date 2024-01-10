using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    /*
     * Bir excel dosyası içindeki verileri PDF formatında rapora dönüştürmek istiyorsunuz.
     * 
     * Her fonksiyon MÜMKÜN OLDUĞUNCA az satırdan oluşmalıdır 
     * Gönül ister ki hepsi teksatır olsun.
     */
    public class ReportGenerator
    {
        private string excelFilePath;
        public ReportGenerator(string path)
        {

            try
            {
                validateFile(path);
                excelFilePath = path;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        bool isFileExists(string path) => File.Exists(path);

        bool isFormatAvailable(string path)
        {
            return true;
        }

        bool isValidFile(string path)
        {
            return isFileExists(path) && isFormatAvailable(path);
        }

        void validateFile(string path)
        {
            if (!isValidFile(path))
            {
                throw new Exception();
            }
        }

    }
}
