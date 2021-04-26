using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridgeClient.Common
{
   
    public enum ProductCategoryType
    {
        [Display(Description = "Select")]
        Select = 0,

        [Display(Description = "Fashion")]
        Fashion = 1,

        [Display(Description = "Mobiles")]
        Mobile = 2,

        [Display(Description = "Electronics")]
        Electronics = 3,

        [Display(Description = "Home")]
        Home = 4,

        [Display(Description = "Appliances")]
        Appliances = 5,

        [Display(Description = "Beauty")]
        Beauty = 6,

        [Display(Description = "Furniture")]
        Furniture = 7,

        [Display(Description = "Grocery")]
        Grocery = 8,

        [Display(Description = "Sports")]
        Sports = 9
    }


    public interface IResult<T>
    {
        bool isError { get; set; }
        int code { get; set; }
        object message { get; set; }
        object subjectId { get; set; }
    }
    public class Result<T> : IResult<T>
    {
        public Result(T resultData)
        {
            data = resultData;
            dataList = new List<T>();
        }

        public Result(int errorCode, object errorMessage)
        {
            this.code = errorCode == 0 ? 500 : errorCode; // default set to 500(internal error) if not specified
            this.message = errorMessage == null ? "Error details not specified" : errorMessage;
            this.isError = true;
        }

        public Result()
        {
            dataList = new List<T>();
        }

        public bool isError { get; set; }
        public int code { get; set; }
        public object message { get; set; }
        public object subjectId { get; set; }
        public T data { get; set; }
        public List<T> dataList { get; set; }
        public dynamic Dynamicdata { get; set; }
        public List<dynamic> DynamicdataList { get; set; }

        public bool ShouldSerializedata()
        {
            return data != null;
        }

        public bool ShouldSerializedataList()
        {
            return dataList != null && dataList.Count > 0;
        }

        public bool ShouldSerializeDynamicdata()
        {
            return Dynamicdata != null;
        }

        public bool ShouldSerializeDynamicdataList()
        {
            return DynamicdataList != null && DynamicdataList.Count > 0;
        }
    }

    public interface IResultData<T>
    {
        public int code { get; set; }
        public object status { get; set; }
        public T result { get; set; }
        public object message { get; set; }
        public object filePath { get; set; }
        public dynamic Dynamicdata { get; set; }
        public List<dynamic> DynamicdataList { get; set; }
    }

    public class ResultData<T> : IResultData<T>
    {
        public ResultData(T resultData)
        {
            result = resultData;
        }

        public ResultData()
        {
        }

        public int code { get; set; }
        public object status { get; set; }
        public T result { get; set; }
        public object message { get; set; }
        public object filePath { get; set; }
        public dynamic Dynamicdata { get; set; }
        public List<dynamic> DynamicdataList { get; set; }
        public string url { get; set; }
    }


    public class GenericSelectList
    {
        public string ValueField { get; set; }
        public string TextField { get; set; }
        public string TextField2 { get; set; }
        public string GroupField { get; set; }
        public string CssField { get; set; }
        public string SelectedValue { get; set; }
        public dynamic AdditionalParams { get; set; }
    }


}
