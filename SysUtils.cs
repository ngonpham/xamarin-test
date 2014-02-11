using System;
using System.Net;
using System.IO;

namespace Hello_iPhone
{
	public class SysUtils
	{
		public static String downloadData(String url) {
			var request = HttpWebRequest.Create(url);
			request.ContentType = "application/json";
			request.Method = "GET";
			HttpWebResponse response = request.GetResponse() as HttpWebResponse;
			StreamReader reader = new StreamReader(response.GetResponseStream());
			return reader.ReadToEnd();
		}
	}
}

