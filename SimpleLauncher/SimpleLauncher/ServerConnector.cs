//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Net;
using System.IO;
namespace SimpleLauncher
{
	/// <summary>
	/// Holds information of a server, and enables requests to that server.
	/// </summary>
	public class ServerConnector {
		/// <summary>
		/// The server's URL.
		/// </summary>
		public string ServerURL;
		public ServerConnector(string url) {
			ServerURL = url;
		}

		/// <summary>
		/// Downloads a file from a given path.
		/// </summary>
		/// <param name="path">Server enpoint path.</param>
		public void Download(string path, string dest) {
			if(File.Exists(dest)) File.Delete (dest);
	
			using(WebClient wc = new WebClient())
			{
				wc.DownloadFile(Path.Combine(ServerURL, path), dest);
			}

			/*using (StreamReader reader = RawRequest(path, "", "application/octet-stream"))
			{
				using(StreamWriter sw = new StreamWriter(dest, false, new System.Text.UTF8Encoding()))
				{
//					while(true)
					{
						String s = reader.ReadToEnd();
						if(i == -1)
							break;
						sw.Write (s);
					}
				}
			}*/
		}

		/// <summary>
		/// Sends a HTTP request to the server under the given path.
		/// </summary>
		/// <param name="path">Server enpoint path.</param>
		public string Request(string path) {
			using (StreamReader reader = RawRequest(path, "", "application/json")) {
				return reader.ReadToEnd();
			}
		}
		
		public StreamReader RawRequest(string path, string data, string contentType) {
			string url = Path.Combine(ServerURL, path);
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			request.Method = "POST";
			request.ContentLength = data.Length;
			request.ContentType = contentType;
			request.UserAgent = "Troposphir Launcher Beta";
			Stream input = request.GetRequestStream();
			input.Write(new System.Text.UTF8Encoding().GetBytes(data), 0, data.Length);
			input.Close();
			Stream output = request.GetResponse().GetResponseStream();
			output.ReadTimeout = 3000;
			return new StreamReader(output);
		}
	}
}

