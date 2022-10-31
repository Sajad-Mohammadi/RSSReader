using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Models;

namespace DAL
{
    public class FileManager
    {
        string pathArtiklar = @".\RssReader\bin\Debug\Artiklar.xml";
        string pathKategorier = @".\RssReader\bin\Debug\Kategorier.xml";

        public void SerializeArtikel(List<Artikel> artiklar)
        {
            if (!DALValidator.IsFileExisting(Path.GetFullPath(Path.Combine(pathArtiklar, @"..\"))))
            {
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(artiklar.GetType());
                    using (FileStream Outfile = new FileStream("Artiklar.xml", FileMode.Create, FileAccess.Write))
                    {
                        xmlSerializer.Serialize(Outfile, artiklar);
                    }
                }
                catch (Exception)
                {
                    throw new SerializerException("Artiklar.xml", "Går ej att serialisera :(");
                }
            }
        }

        public List<Artikel> DeserializeArtikel()
        {
            try
            {
                List<Artikel> artiklarToBeReturned;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Artikel>));
                using (FileStream inFile = new FileStream("Artiklar.xml", FileMode.Open, FileAccess.Read))
                {
                    artiklarToBeReturned = (List<Artikel>)xmlSerializer.Deserialize(inFile);
                }
                return artiklarToBeReturned;
            }
            catch (Exception)
            {
                throw new SerializerException("Artiklar.xml", "Går ej att deserialisera :(");
            }
        }

        public void SerializeKategori(List<Kategori> kategorier)
        {
            if (!DALValidator.IsFileExisting(Path.GetFullPath(Path.Combine(pathKategorier, @"..\"))))
            {
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(kategorier.GetType());
                    using (FileStream outFile = new FileStream("Kategorier.xml", FileMode.Create, FileAccess.Write))
                    {
                        xmlSerializer.Serialize(outFile, kategorier);
                    }
                }
                catch (Exception)
                {
                    throw new SerializerException("Kategorier.xml", "Går ej att serialisera :(");
                }
            }
        }

        public List<Kategori> DeserializeKategori()
        {
            try
            {
                List<Kategori> kategoriListToBeReturned;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kategori>));
                using (FileStream inFile = new FileStream("Kategorier.xml", FileMode.Open, FileAccess.Read))
                {
                    kategoriListToBeReturned = (List<Kategori>)xmlSerializer.Deserialize(inFile);
                }
                return kategoriListToBeReturned;
            }
            catch (Exception)
            {
                throw new SerializerException("Kategorier.xml", "Går ej att deserialisera :(");
            }
        }
    }
}
