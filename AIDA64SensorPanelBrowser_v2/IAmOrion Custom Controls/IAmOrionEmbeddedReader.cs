using System;
using System.Reflection;
using System.IO;
using System.Text;

namespace AIDA64SensorPanelBrowser_v2
{
	/// <summary>
	/// Summary description for EmbeddedResourceReader.
	/// </summary>
	public class EmbeddedResourceTextReader
	{
		public EmbeddedResourceTextReader()
		{

		}
		internal string GetFromResources(string resourceName)
		{
			Assembly assem = this.GetType().Assembly;
			using (Stream stream = assem.GetManifestResourceStream(resourceName))
			{
				try
				{
					using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
					{
						return reader.ReadToEnd();
					}
				}
				catch (Exception e)
				{
					throw new Exception("Error retrieving from Resources.   Tried '" + resourceName + "'\r\n" + e.ToString());
				}
			}
		}
	}
}
