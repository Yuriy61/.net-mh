using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Quartz;

namespace MyWeb.Quart.Job
{
    public class RefreshTokenJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            string AppID = "";// model.AppID;
            string AppSecret = "";// model.AppSecret;
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}", AppID, AppSecret);
            HttpWebRequest http = HttpWebRequest.CreateHttp(url);
            AccessTokenResponse data = null;
            using (HttpWebResponse response = http.GetResponse() as HttpWebResponse)
            {
                data = (AccessTokenResponse)new DataContractJsonSerializer(typeof(AccessTokenResponse)).ReadObject(response.GetResponseStream());
                if ((data == null) || string.IsNullOrEmpty(data.access_token))
                {
                    MyWeb.Helper.LogHelper.Error("获取微信token失败");
                    return;
                    //获取成功
                }
            }
            if (data != null && !string.IsNullOrEmpty(data.access_token))
            {
                string ticketUrl = string.Format("https://api.weixin.qq.com/cgi-bin/ticket/getticket?access_token={0}&type=jsapi", data.access_token);
                using (HttpWebResponse response = HttpWebRequest.CreateHttp(ticketUrl).GetResponse() as HttpWebResponse)
                {
                    JSApiTicketResponse ticketData = (JSApiTicketResponse)new DataContractJsonSerializer(typeof(JSApiTicketResponse)).ReadObject(response.GetResponseStream());
                    if ((ticketData != null) && !string.IsNullOrEmpty(ticketData.ticket))
                    {
                        /*model.AppID = AppID;
                        model.AppSecret = AppSecret;
                        model.Name = "";
                        model.AccessToken = data.access_token;
                        model.JsApiTicket = ticketData.ticket;
                        model.Expires = DateTime.Now.AddMinutes(int.Parse(ticketData.expires_in));
                        dal.Update(model);*/
                        //获取成功
                    }
                }
            }
            throw new NotImplementedException();
        }
    }

    [DataContract]
    class AccessTokenResponse
    {
        [DataMember]
        public string access_token { get; set; }

        [DataMember]
        public string expires_in { get; set; }

        [DataMember]
        public string errmsg { get; set; }

        [DataMember]
        public string errcode { get; set; }
    }
    [DataContract]
    class JSApiTicketResponse
    {
        [DataMember]
        public string ticket { get; set; }

        [DataMember]
        public string expires_in { get; set; }

        [DataMember]
        public string errmsg { get; set; }

        [DataMember]
        public string errcode { get; set; }
    }
}