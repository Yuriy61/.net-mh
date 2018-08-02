﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using MyWeb.Helper;
using AMW.DB.SQLSERVER;
namespace MyWeb.Areas.WebAdmin.Controllers
{
    public class ImageController : Controller
    {
        #region 上传图片
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            UploadFileResult result = file.FileUpLoad("img", 1024 * 1024 * 4, "images");
            
            if (result.Ok)
            {
                return Json(new
                {
                    ok = true,
                    url = result.Data
                });
            }
            else {
                return Json(new
                {
                    ok = false,
                    error = result.Data
                });
            }
        }
        #endregion

        #region 验证码
        //// <summary>
        /// 生成验证码
        /// </summary>
        /// <param name="length">指定验证码的长度</param>
        /// <returns></returns>
        public string CreateValidateCode(int length)
        {
            int[] randMembers = new int[length];
            int[] validateNums = new int[length];
            string validateNumberStr = "";
            //生成起始序列值
            int seekSeek = unchecked((int)DateTime.Now.Ticks);
            Random seekRand = new Random(seekSeek);
            int beginSeek = (int)seekRand.Next(0, Int32.MaxValue - length * 10000);
            int[] seeks = new int[length];
            for (int i = 0; i < length; i++)
            {
                beginSeek += 10000;
                seeks[i] = beginSeek;
            }
            //生成随机数字
            for (int i = 0; i < length; i++)
            {
                Random rand = new Random(seeks[i]);
                int pownum = 1 * (int)Math.Pow(10, length);
                randMembers[i] = rand.Next(pownum, Int32.MaxValue);
            }
            //抽取随机数字
            for (int i = 0; i < length; i++)
            {
                string numStr = randMembers[i].ToString();
                int numLength = numStr.Length;
                Random rand = new Random();
                int numPosition = rand.Next(0, numLength - 1);
                validateNums[i] = Int32.Parse(numStr.Substring(numPosition, 1));
            }
            //生成验证码
            for (int i = 0; i < length; i++)
            {
                validateNumberStr += validateNums[i].ToString();
            }
            return validateNumberStr;
        }
        /// <summary>
        /// 创建验证码的图片
        /// </summary>
        /// <param name="containsPage">要输出到的page对象</param>
        /// <param name="validateNum">验证码</param>
        public byte[] CreateValidateGraphic(string validateCode)
        {
            Bitmap image = new Bitmap(71, 41);
            Graphics g = Graphics.FromImage(image);
            try
            {
                //生成随机生成器
                Random random = new Random();
                //清空图片背景色
                g.Clear(Color.White);
                //画图片的干扰线
                for (int i = 0; i < 25; i++)
                {
                    int x1 = random.Next(image.Width);
                    int x2 = random.Next(image.Width);
                    int y1 = random.Next(image.Height);
                    int y2 = random.Next(image.Height);
                    g.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);
                }
                Font font = new Font("Arial", 12, (FontStyle.Bold | FontStyle.Italic));
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height),
                 Color.Blue, Color.DarkRed, 1.2f, true);
                g.DrawString(validateCode, font, brush, 5, 12);
                //画图片的前景干扰点
                for (int i = 0; i < 100; i++)
                {
                    int x = random.Next(image.Width);
                    int y = random.Next(image.Height);
                    image.SetPixel(x, y, Color.FromArgb(random.Next()));
                }
                //画图片的边框线
                //g.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);
                //保存图片数据
                MemoryStream stream = new MemoryStream();
                image.Save(stream, ImageFormat.Jpeg);
                //输出图片流
                return stream.ToArray();
            }
            finally
            {
                g.Dispose();
                image.Dispose();
            }
        }
        public ActionResult ValidateCode()
        {
            string code = CreateValidateCode(6);
            SessionHelper.ValidateCode = code;
            byte[] bytes = CreateValidateGraphic(code);
            return File(bytes, @"image/jpeg");
        }
        #endregion

        #region 获取图片
         [OutputCache(Duration = 0x7FFFFFFF)]
        public ActionResult ImageByID(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return HttpNotFound();
            }
            string path = DBHelper.From("Rs_image").Take("folder").Where("ImageID=@1", id).QueryString();
            if (string.IsNullOrEmpty(path))
            {
                return HttpNotFound();
            }
            else
            {
                Response.Cache.SetOmitVaryStar(true);
                return File(Server.MapPath(string.Format("~/upload/{0}/{1}", path, id)), "image/png");
            }
        }
        #endregion
    }
}