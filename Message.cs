//using ExpressSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExpressSystem
{
    public class Message
    {
        //表示状态  例如数据是否有效\ etc 
        //需要进行相关约定   例如 0表示正常
        public int status { get; set; }

        //存放信息
        public Dictionary<string, dynamic> data { get; set; } = new Dictionary<string, dynamic>();

        //将信息转换成json格式
        public string ToJson()
        {
            //防止对一个对象同时进行修改
            lock (this)
            {
                try
                {
                    return JsonConvert.SerializeObject(this);
                }
                catch { }
                return null;   //异常返回null
            }           
        }
    }


    //类似于ViewModel的角色   将所有前后端需要传递的信息封装
    public class AccountMessage : Message
    {   
        //初始化  把觉得需要的键值对都先Add到字典中
        //之后需要可以直接改   syntax: data["ID"] = "12345";
        public AccountMessage()
        {
            status = 0;
            data.Add("ID", null);
            data.Add("PASSWORD", null);
            data.Add("ROLE", null);
        }
    }

    public class CollectMessage: Message
    {
        public CollectMessage()
        {
            status = 0;
            data.Add("PACK_ID", null);
            data.Add("ADDRESS", null);
            data.Add("STATE", null);
            data.Add("RECIPIENT_ID", null);
        }
    }
}
