﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace V2RayGCon.Resource.Resx {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Data {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Data() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("V2RayGCon.Resource.Resx.Data", typeof(Data).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 {
        ///  &quot;inTpl&quot;: {
        ///    &quot;port&quot;: 1080,
        ///    &quot;listen&quot;: &quot;127.0.0.1&quot;,
        ///    &quot;protocol&quot;: &quot;协议名称&quot;,
        ///    &quot;settings&quot;: {},
        ///    &quot;streamSettings&quot;: {},
        ///    &quot;tag&quot;: &quot;标识&quot;,
        ///    &quot;domainOverride&quot;: [
        ///      &quot;http&quot;,
        ///      &quot;tls&quot;
        ///    ]
        ///  },
        ///  &quot;inSS&quot;: {
        ///    &quot;email&quot;: &quot;love@v2ray.com&quot;,
        ///    &quot;method&quot;: &quot;aes-128-cfb&quot;,
        ///    &quot;password&quot;: &quot;密码&quot;,
        ///    &quot;udp&quot;: false,
        ///    &quot;level&quot;: 0,
        ///    &quot;ota&quot;: true,
        ///    &quot;network&quot;: &quot;tcp&quot;
        ///  },
        ///  &quot;inHTTP&quot;: {
        ///    &quot;timeout&quot;: 0,
        ///    &quot;accounts&quot;: [
        ///      {
        ///        &quot;user&quot;: &quot;my-username&quot;,
        ///        &quot;pass&quot;: &quot; [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string config_def {
            get {
                return ResourceManager.GetString("config_def", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {
        ///  &quot;log&quot;: {
        ///    &quot;loglevel&quot;: &quot;warning&quot;
        ///  },
        ///  &quot;inbound&quot;: {
        ///    &quot;port&quot;: 1080,
        ///    &quot;listen&quot;: &quot;127.0.0.1&quot;,
        ///    &quot;protocol&quot;: &quot;socks&quot;,
        ///    &quot;settings&quot;: {
        ///      &quot;auth&quot;: &quot;noauth&quot;,
        ///      &quot;udp&quot;: false,
        ///      &quot;ip&quot;: &quot;127.0.0.1&quot;
        ///    }
        ///  },
        ///  &quot;outbound&quot;: {
        ///    &quot;protocol&quot;: &quot;freedom&quot;,
        ///    &quot;settings&quot;: {},
        ///    &quot;tag&quot;: &quot;direct&quot;
        ///  },
        ///  &quot;policy&quot;: {
        ///    &quot;levels&quot;: {
        ///      &quot;0&quot;: {&quot;uplinkOnly&quot;: 0}
        ///    }
        ///  }
        ///}
        /// 的本地化字符串。
        /// </summary>
        internal static string config_min {
            get {
                return ResourceManager.GetString("config_min", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {
        ///  &quot;vgc&quot;: {
        ///    &quot;alias&quot;: &quot;&quot;,
        ///    &quot;description&quot;: &quot;&quot;
        ///  },
        ///  &quot;vmessClient&quot;: {
        ///    &quot;vnext&quot;: [
        ///      {
        ///        &quot;address&quot;: &quot;127.0.0.1&quot;,
        ///        &quot;port&quot;: 37192,
        ///        &quot;users&quot;: [
        ///          {
        ///            &quot;id&quot;: &quot;27848739-7e62-4138-9fd3-098a63964b6b&quot;,
        ///            &quot;alterId&quot;: 10,
        ///            &quot;security&quot;: &quot;auto&quot;,
        ///            &quot;level&quot;: 0
        ///          }
        ///        ]
        ///      }
        ///    ]
        ///  },
        ///  &quot;httpIn&quot;: {
        ///    &quot;timeout&quot;: 0,
        ///    &quot;accounts&quot;: [],
        ///    &quot;allowTransparent&quot;: false,
        ///    &quot;userLevel&quot;: 0
        ///  },
        ///  &quot;socksIn&quot;: [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string config_tpl {
            get {
                return ResourceManager.GetString("config_tpl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 v3.26 的本地化字符串。
        /// </summary>
        internal static string DefCoreVersion {
            get {
                return ResourceManager.GetString("DefCoreVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 [A-Za-z0-9+/]+ 的本地化字符串。
        /// </summary>
        internal static string DontUsePatternBase64 {
            get {
                return ResourceManager.GetString("DontUsePatternBase64", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 https://github.com/v2ray/v2ray-core/releases/download/{0}/{1} 的本地化字符串。
        /// </summary>
        internal static string DownloadLinkTpl {
            get {
                return ResourceManager.GetString("DownloadLinkTpl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 vmess://ew0KICAicHMiOiAiZHVtbXkxIiwNCiAgImFkZCI6ICIxLjIuMy40IiwNCiAgInBvcnQiOiAiNDQzIiwNCiAgImlkIjogImI4NzNkNWY0LTMyNjEtNGYxOS04MGE3LWYwZTY3YzkwYzA4MiIsDQogICJhaWQiOiAiMTAwIiwNCiAgIm5ldCI6ICJ3cyIsDQogICJ0eXBlIjogIm5vbmUiLA0KICAiaG9zdCI6ICIvcmF5IiwNCiAgInRscyI6ICJ0bHMiDQp9 的本地化字符串。
        /// </summary>
        internal static string DummyServ1 {
            get {
                return ResourceManager.GetString("DummyServ1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 vmess://ew0KICAicHMiOiAiZHVtbXkyIiwNCiAgImFkZCI6ICIyLjMuNC41IiwNCiAgInBvcnQiOiAiMTIzNCIsDQogICJpZCI6ICI1NjIxODM4ZS1hYmM1LTRiNmQtOWQzMS00MmUwOGE3ZWMzMmYiLA0KICAiYWlkIjogIjY0IiwNCiAgIm5ldCI6ICJ0Y3AiLA0KICAidHlwZSI6ICJub25lIiwNCiAgImhvc3QiOiAiIiwNCiAgInRscyI6ICIiDQp9 的本地化字符串。
        /// </summary>
        internal static string DummyServ2 {
            get {
                return ResourceManager.GetString("DummyServ2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 v2ray.exe 的本地化字符串。
        /// </summary>
        internal static string Executable {
            get {
                return ResourceManager.GetString("Executable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Json File|*.json|All File|*.* 的本地化字符串。
        /// </summary>
        internal static string ExtJson {
            get {
                return ResourceManager.GetString("ExtJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 PNG Files|*.png|All File|*.* 的本地化字符串。
        /// </summary>
        internal static string ExtPng {
            get {
                return ResourceManager.GetString("ExtPng", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Text File|*.txt|All File|*.* 的本地化字符串。
        /// </summary>
        internal static string ExtText {
            get {
                return ResourceManager.GetString("ExtText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 https://github.com/v2ray/v2ray-core/releases/latest 的本地化字符串。
        /// </summary>
        internal static string LatestCoreLink {
            get {
                return ResourceManager.GetString("LatestCoreLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 (?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{4}) 的本地化字符串。
        /// </summary>
        internal static string PatternBase64 {
            get {
                return ResourceManager.GetString("PatternBase64", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /v2ray/v2ray-core/releases/download/(v[\.0-9]+)/v2ray-windows-64.zip 的本地化字符串。
        /// </summary>
        internal static string PatternDownloadLink {
            get {
                return ResourceManager.GetString("PatternDownloadLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /nobody3u/V2RayGCon/releases/tag/([\.0-9]+) 的本地化字符串。
        /// </summary>
        internal static string PatternLatestVGC {
            get {
                return ResourceManager.GetString("PatternLatestVGC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 [^0-9a-zA-Z] 的本地化字符串。
        /// </summary>
        internal static string PatternNonAlphabet {
            get {
                return ResourceManager.GetString("PatternNonAlphabet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 v2ray-windows-32.zip 的本地化字符串。
        /// </summary>
        internal static string PkgWin32 {
            get {
                return ResourceManager.GetString("PkgWin32", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 v2ray-windows-64.zip 的本地化字符串。
        /// </summary>
        internal static string PkgWin64 {
            get {
                return ResourceManager.GetString("PkgWin64", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 https://github.com/v2ray/v2ray-core/releases 的本地化字符串。
        /// </summary>
        internal static string ReleasePageUrl {
            get {
                return ResourceManager.GetString("ReleasePageUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 https://github.com/nobody3u/V2RayGCon/releases/tag/{0} 的本地化字符串。
        /// </summary>
        internal static string TplUrlVGCRelease {
            get {
                return ResourceManager.GetString("TplUrlVGCRelease", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 https://github.com/nobody3u/V2RayGCon/releases/latest 的本地化字符串。
        /// </summary>
        internal static string UrlLatestVGC {
            get {
                return ResourceManager.GetString("UrlLatestVGC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 v3.26,v3.21,v3.18 的本地化字符串。
        /// </summary>
        internal static string VerList {
            get {
                return ResourceManager.GetString("VerList", resourceCulture);
            }
        }
    }
}
