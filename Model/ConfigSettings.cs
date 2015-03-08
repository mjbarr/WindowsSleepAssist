using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace Model
{       
    [Serializable]
    public class ConfigSettings
    {
        #region -- ConfigSettings Class
        /// <summary>
        /// Stores and retrieves all user customizable settings by serializing
        /// to disk as xml
        /// </summary>


            #region Fields

        private bool m_hibernate;
        private int m_minsUntilSleep;
            int m_Version;

            #endregion Fields



            #region Constructors

            private ConfigSettings()
            {
                m_Version = 1;
                m_minsUntilSleep = 15;
                m_hibernate = false;
            }

            #endregion Constructors

            #region Properties

            public bool Hibernate
            {
                get { return m_hibernate; }
                set
                {
                    m_hibernate = value;
                    Save();
                }
            }

            public int NoOfMinsUntilSleep
            {
                get { return m_minsUntilSleep; }
                set
                {
                    m_minsUntilSleep = value;
                    Save();

                }
            }
            public int Version
            {
                get { return m_Version; }
                set { m_Version = value;
                Save();
                }
            }

            private static string FileName
            {
                get
                {
                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WindowsSleepAssist");

                    if (Directory.Exists(path))
                    {

                    }
                    else
                    {
                        Directory.CreateDirectory(path);
                    }

                    return Path.Combine(path, "Config.ini");
                }
            }

            #endregion Properties

            #region Methods

            public static object Deserialize(string xml, Type toType)
            {
                using (Stream stream = new MemoryStream())
                {
                    byte[] data = System.Text.Encoding.UTF8.GetBytes(xml);
                    stream.Write(data, 0, data.Length);
                    stream.Position = 0;
                    DataContractSerializer deserializer = new DataContractSerializer(toType);
                    return deserializer.ReadObject(stream);
                }
            }

            public static ConfigSettings getSettings()
            {
                try
                {
                    return Load();
                }
                catch (Exception)
                {
                    return new ConfigSettings();
                }
            }

            /// <summary>
            /// Load an object from an xml file
            /// </summary>
            /// <param name="FileName">Xml file name</param>
            /// <returns>The object created from the xml file</returns>
            private static ConfigSettings Load()
            {
                var stream = System.IO.File.OpenRead(FileName);

                //var serializer = new XmlSerializer(typeof(MemoPadMediator));
                //return serializer.Deserialize(stream) as MemoPadMediator;
                StringBuilder sb = new StringBuilder();
                using (StreamReader sr = new StreamReader(stream))
                {
                    String line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        sb.AppendLine(line);
                    }
                }
                string xml = sb.ToString();
                return (ConfigSettings)Deserialize(xml, typeof(ConfigSettings));
            }

            /// <summary>
            /// Saves to an xml file
            /// </summary>
            /// <param name="FileName">File path of the new xml file</param>
            private void Save()
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(ConfigSettings));

                var settings = new XmlWriterSettings()
                {
                    Indent = true,
                    IndentChars = "\t"
                };

                XmlWriter writer = XmlWriter.Create(@FileName, settings);
                serializer.WriteObject(writer, this);
                writer.Flush();
                writer.Close();

            }

            #endregion Methods
        }
        #endregion
    }

