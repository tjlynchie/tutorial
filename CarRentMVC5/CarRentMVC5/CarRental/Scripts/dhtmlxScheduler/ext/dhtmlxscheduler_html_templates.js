/*
@license
dhtmlxScheduler.Net v.3.3.0 

This software is covered by DHTMLX Evaluation License. Contact sales@dhtmlx.com to get Commercial or Enterprise license. Usage without proper license is prohibited.

(c) Dinamenta, UAB.
*/
Scheduler.plugin(function(e){e.attachEvent("onTemplatesReady",function(){for(var t=document.body.getElementsByTagName("DIV"),n=0;n<t.length;n++){var a=t[n].className||"";if(a=a.split(":"),2==a.length&&"template"==a[0]){var d='return "'+(t[n].innerHTML||"").replace(/\"/g,'\\"').replace(/[\n\r]+/g,"")+'";';d=unescape(d).replace(/\{event\.([a-z]+)\}/g,function(e,t){return'"+ev.'+t+'+"'}),e.templates[a[1]]=Function("start","end","ev",d),t[n].style.display="none"}}})});