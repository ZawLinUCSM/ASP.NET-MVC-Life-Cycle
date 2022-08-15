using System;
using System.Web;
using System.Xml;

namespace CustomHttpHandler
{
    public class RssHandler : IHttpHandler
    {
        /// <summary>
        /// You will need to configure this handler in the Web.config file of your 
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpHandler Members

        public bool IsReusable
        {
            // Return false in case your Managed Handler cannot be reused for another request.
            // Usually this would be false in case you have some state information preserved per request.
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/xml";

            using (XmlWriter writer = XmlWriter.Create(context.Response.OutputStream))
            {
                writer.WriteStartDocument();
                writer.WriteElementString("rss", "Roux Academy RSS Feed");
                writer.WriteEndDocument();
                writer.Flush();
            }
        }

        #endregion
    }
}
