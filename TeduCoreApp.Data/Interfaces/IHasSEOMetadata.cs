namespace TeduCoreApp.Data.Interfaces
{
    /// <summary>
    /// Class nào triển khai sẽ có các thuộc tính này
    /// </summary>
    public interface IHasSEOMetadata
    {
        /// <summary>
        /// Tiêu đề trang cần SEO
        /// </summary>
        string SeoPageTitle { get; set; }

        string SeoAlias { get; set; }
        /// <summary>
        /// 
        /// </summary>
        string SeoKeywords { get; set; }
        string SeoDescriptions { get; set; }
    }
}