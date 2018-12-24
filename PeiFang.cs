using System;

public class Class1
{
    public class HcItem
    {
        /// <summary>
        /// 龙虾
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string num { get; set; }
    }

    public class Need_sp_info
    {

    /// 
    /// </summary>
    public string name { get; set; }
}

public class Root
{
    /// <summary>
    /// 
    /// </summary>
    public string id { get; set; }
    /// <summary>
    /// 龙虾大餐
    /// </summary>
    public string name { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string img { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string type { get; set; }
    /// <summary>
    /// 【配方】龙虾


    /// </summary>
    public string jianjie { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<HcItem> hc { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string listorder { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string zjtj { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> hc_sp_id { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Need_sp_info need_sp_info { get; set; }
}
}
