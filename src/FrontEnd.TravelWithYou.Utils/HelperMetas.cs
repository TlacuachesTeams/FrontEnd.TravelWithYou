using System.Collections.Generic;
using System.Linq;
using FrontEnd.TravelWithYou.Entities.Common;
using FrontEnd.TravelWithYou.Entities.Common.Metas;

namespace FrontEnd.TravelWithYou.Utils
{

    /// <summary>
    /// Helper Metas
    /// </summary>
    public abstract class HelperMetas
    {

        /// <summary>
        /// Get Metas
        /// </summary>
        /// <param name="metas"></param>
        /// <param name="page"></param>
        /// <param name="replaceKeys"></param>
        /// <returns></returns>
        public static List<string> GetMetas(List<Meta> metas, string page, List<KeyValue> replaceKeys = null) {
            List<string> tagsMetas = new List<string>();
            if (metas != null) {
                var dataMeta = metas.Where(mt => ExistPage(mt.Page, page) || mt.Page.Equals("all")).ToList();
                if (dataMeta != null) {
                    dataMeta.ForEach(mt => {
                        string tagMeta = "";
                        string tagMetaAttribute = "";
                        if (!string.IsNullOrEmpty(mt.Name))
                        {
                            tagMetaAttribute += $" name='{mt.Name}'";
                        }
                        if (!string.IsNullOrEmpty(mt.Property))
                        {
                            tagMetaAttribute += $" property='{mt.Property}'";
                        }
                        if (!string.IsNullOrEmpty(mt.Content))
                        {
                            tagMetaAttribute += $" content='{mt.Content}'";
                        }
                        if (!string.IsNullOrEmpty(mt.Rel))
                        {
                            tagMetaAttribute += $" rel='{mt.Rel}'";
                        }
                        if (!string.IsNullOrEmpty(mt.Href))
                        {
                            tagMetaAttribute += $" href='{mt.Href}'";
                        }                        
                        //Metas
                        if (mt.TypeId == 1)
                        {                           
                            if (!string.IsNullOrEmpty(tagMetaAttribute)) {
                                tagMeta = $"<meta{tagMetaAttribute}/>\n";                                
                            }                           
                        }
                        //Link
                        if (mt.TypeId == 2)
                        {
                            if (!string.IsNullOrEmpty(tagMetaAttribute))
                            {
                                tagMeta = $"<link{tagMetaAttribute}/>\n";                               
                            }
                        }
                        //Title
                        if (mt.TypeId == 3)
                        {
                            if (!string.IsNullOrEmpty(mt.Text))
                            {
                                tagMeta = $"<title>{mt.Text}</title>\n";
                            }
                        }
                        if (!string.IsNullOrEmpty(tagMeta)) {
                            tagMeta = ReplaceKeys(replaceKeys, tagMeta);
                            tagsMetas.Add(tagMeta);
                        }
                    });
                }                
            }
            //string result = string.Join("", tagsMetas.ToArray());
            return tagsMetas;
        }

        private static bool ExistPage(string pages, string findPage) {
            var pagesData = pages.Split(",");
            foreach (var page in pagesData)
            {
                if (page.Equals(findPage)) {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Replace Key Metas
        /// </summary>
        /// <param name="replaceKeys"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string ReplaceKeys(List<KeyValue> replaceKeys, string text) {
            if (replaceKeys != null) {
                replaceKeys.ForEach(ky => {
                    text = text.Replace(ky.Key, ky.Value);
                });
            }
            return text;
        }
    }
}
