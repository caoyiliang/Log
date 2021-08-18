/********************************************************************
 * *
 * * 使本项目源码或本项目生成的DLL前请仔细阅读以下协议内容，如果你同意以下协议才能使用本项目所有的功能，
 * * 否则如果你违反了以下协议，有可能陷入法律纠纷和赔偿，作者保留追究法律责任的权利。
 * *
 * * 1、你可以在开发的软件产品中使用和修改本项目的源码和DLL，但是请保留所有相关的版权信息。
 * * 2、不能将本项目源码与作者的其他项目整合作为一个单独的软件售卖给他人使用。
 * * 3、不能传播本项目的源码和DLL，包括上传到网上、拷贝给他人等方式。
 * * 4、以上协议暂时定制，由于还不完善，作者保留以后修改协议的权利。
 * *
 * * Copyright ©2013-? yzlm Corporation All rights reserved.
 * * 作者： 曹一梁 QQ：347739303
 * * 请保留以上版权信息，否则作者将保留追究法律责任。
 * *
 * * 创建时间：2021-06-28
 * * 说明：CustomerLog.cs
 * *
********************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Utils.PushQueue;

namespace CustomerLog
{
    public class CustomerLog : ICustomerLog
    {
        public static readonly ICustomerLog Instance = new CustomerLog();
        private PushQueue<DirectoryNameAndContent> _pushQueue;
        private string _path = AppDomain.CurrentDomain.BaseDirectory;
        private CustomerLog()
        {
            _pushQueue = new PushQueue<DirectoryNameAndContent>()
            {
                MaxCacheCount = 100
            };
            _pushQueue.OnPushData += _pushQueue_OnPushData;
            _pushQueue.StartAsync().Wait();
        }

        private async Task _pushQueue_OnPushData(DirectoryNameAndContent arg)
        {
            var path = Path.Combine("Logs", $"{DateTime.Now:yyyyMM}", arg.DirectoryName);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            var fileName = Path.Combine(path, $"{DateTime.Now:yyyyMMdd}.txt");
            File.AppendAllText(fileName, arg.Content);
        }

        private string AddTime(string msg)
        {
            return $"{DateTime.Now:yyyy/MM/dd HH:mm:ss:fff}    {msg}{Environment.NewLine}";
        }

        public void Write(string directoryName, string content)
        {
            _pushQueue.PutInData(new DirectoryNameAndContent()
            {
                DirectoryName = directoryName,
                Content = AddTime(content),
            });
        }
    }
    internal class DirectoryNameAndContent
    {
        internal string DirectoryName { get; set; }
        internal string Content { get; set; }
    }
}
