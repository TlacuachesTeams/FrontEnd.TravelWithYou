using System;
using System.Linq;

namespace FrontEnd.TravelWithYou.Utils
{
    public static class PathHelper
    {
        public static string PathValidate(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return string.Empty;
            }
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            bool isLocal = (environment.ToLower().Equals("local") ? true : false);
            string cdnPath = string.Empty;
            //El path no tiene http:// o https://
            if (path.ToLower().IndexOf("http") == -1 && !isLocal)
            {
                cdnPath = Environment.GetEnvironmentVariable("PATH_CDN") ?? "";
                path = $"{cdnPath}{path}";
            }
            string pathResult = path;
            string[] split;
            int i = 0;
            split = path.Split("/").Where(c => !string.IsNullOrEmpty(c)).ToArray();
            if (split[0].ToLower().Contains("http"))
            {
                pathResult = $"{split[0]}//";
                i = 1;
            }
            else
            {
                pathResult = "/";
                if (!isLocal)
                {
                    pathResult = "//";
                }
            }
            for (; i < split.Count(); i++)
            {
                pathResult += split[i];
                if (i + 1 < split.Count())
                {
                    pathResult += "/";
                }
            }
            return pathResult;
        }

        ///// <summary>
        ///// Remove Image Not Found
        ///// </summary>
        ///// <param name="images"></param>
        ///// <returns></returns>
        //public static List<HotelImage> RemoveImageNotFound(List<HotelImage> images)
        //{
        //    List<HotelImage> resultImages = new List<HotelImage>();
        //    try
        //    {
        //        //Revisa si la imagen existe
        //        if (images != null && images.Count > 0)
        //        {
        //            var index = 0;
        //            images.ForEach(im =>
        //            {
        //                if (!string.IsNullOrEmpty(im.ImagePath))
        //                {
        //                    bool isValid = UrlIsValid(im.ImagePath);
        //                    if (isValid)
        //                    {
        //                        resultImages.Add(im);
        //                    }
        //                }
        //                index += 1;
        //            });
        //        }
        //    }
        //    catch
        //    {
        //        resultImages.AddRange(images); //Si occurre cualquier error regreso la lista original
        //    }
        //    return resultImages;
        //}

        ///// <summary>
        ///// This method will check a url to see that it does not return server or protocol errors
        ///// </summary>
        ///// <param name="url">The path to check</param>
        ///// <returns></returns>
        //private static bool UrlIsValid(string url)
        //{
        //    try
        //    {
        //        HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
        //        request.Timeout = 5000; //set the timeout to 5 seconds to keep the user from waiting too long for the page to load
        //        request.Method = "HEAD"; //Get only the header information -- no need to download any content

        //        using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
        //        {
        //            int statusCode = (int)response.StatusCode;
        //            if (statusCode >= 100 && statusCode < 400) //Good requests
        //            {
        //                return true;
        //            }
        //            else if (statusCode >= 500 && statusCode <= 510) //Server Errors
        //            {
        //                //log.Warn(String.Format("The remote server has thrown an internal error. Url is not valid: {0}", url));
        //                //Debug.WriteLine(String.Format("The remote server has thrown an internal error. Url is not valid: {0}", url));
        //                return false;
        //            }
        //        }
        //    }
        //    catch (WebException ex)
        //    {
        //        if (ex.Status == WebExceptionStatus.ProtocolError) //400 errors
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return false;
        //            //log.Warn(String.Format("Unhandled status [{0}] returned for url: {1}", ex.Status, url), ex);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //        //log.Error(String.Format("Could not test url {0}.", url), ex);
        //    }
        //    return false;
        //}

    }
}
