copy Startup.bat Kooboo_CMS\Startup.bat

"C:\Program Files\Microsoft SDKs\Windows Azure\.NET SDK\v2.2\bin\cspack.exe" ServiceDefinition.csdef /role:Kooboo.CMS.Web;Kooboo_CMS /sites:Kooboo.CMS.Web;/;Kooboo_CMS /rolePropertiesFile:Kooboo.CMS.Web;properties.txt /out:Kooboo_CMS.cspkg 
