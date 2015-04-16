/*
@license
dhtmlxScheduler.Net v.3.3.0 

This software is covered by DHTMLX Evaluation License. Contact sales@dhtmlx.com to get Commercial or Enterprise license. Usage without proper license is prohibited.

(c) Dinamenta, UAB.
*/
Scheduler.plugin(function(e){e.form_blocks.combo={render:function(e){e.cached_options||(e.cached_options={});var t="";return t+="<div class='"+e.type+"' style='height:"+(e.height||20)+"px;' ></div>"},set_value:function(t,n,a,d){!function(){function n(){if(t._combo&&t._combo.DOMParent){var e=t._combo;e.unload?e.unload():e.destructor&&e.destructor(),e.DOMParent=e.DOMelem=null}}n();var a=e.attachEvent("onAfterLightbox",function(){n(),e.detachEvent(a)})}(),window.dhx_globalImgPath=d.image_path||"/",t._combo=new dhtmlXCombo(t,d.name,t.offsetWidth-8),
d.onchange&&t._combo.attachEvent("onChange",d.onchange),d.options_height&&t._combo.setOptionHeight(d.options_height);var i=t._combo;if(i.enableFilteringMode(d.filtering,d.script_path||null,!!d.cache),d.script_path){var r=a[d.map_to];r?d.cached_options[r]?(i.addOption(r,d.cached_options[r]),i.disable(1),i.selectOption(0),i.disable(0)):dhtmlxAjax.get(d.script_path+"?id="+r+"&uid="+e.uid(),function(e){var t=e.doXPath("//option")[0],n=t.childNodes[0].nodeValue;d.cached_options[r]=n,i.addOption(r,n),i.disable(1),
i.selectOption(0),i.disable(0)}):i.setComboValue("")}else{for(var o=[],_=0;_<d.options.length;_++){var l=d.options[_],s=[l.key,l.label,l.css];o.push(s)}if(i.addOption(o),a[d.map_to]){var c=i.getIndexByValue(a[d.map_to]);i.selectOption(c)}}},get_value:function(e,t,n){var a=e._combo.getSelectedValue();return n.script_path&&(n.cached_options[a]=e._combo.getSelectedText()),a},focus:function(e){}},e.form_blocks.radio={render:function(t){var n="";n+="<div class='dhx_cal_ltext dhx_cal_radio' style='height:"+t.height+"px;' >";

for(var a=0;a<t.options.length;a++){var d=e.uid();n+="<input id='"+d+"' type='radio' name='"+t.name+"' value='"+t.options[a].key+"'><label for='"+d+"'> "+t.options[a].label+"</label>",t.vertical&&(n+="<br/>")}return n+="</div>"},set_value:function(e,t,n,a){for(var d=e.getElementsByTagName("input"),i=0;i<d.length;i++){d[i].checked=!1;var r=n[a.map_to]||t;d[i].value==r&&(d[i].checked=!0)}},get_value:function(e,t,n){for(var a=e.getElementsByTagName("input"),d=0;d<a.length;d++)if(a[d].checked)return a[d].value;

},focus:function(e){}},e.form_blocks.checkbox={render:function(t){return e.config.wide_form?'<div class="dhx_cal_wide_checkbox" '+(t.height?"style='height:"+t.height+"px;'":"")+"></div>":""},set_value:function(t,n,a,d){t=document.getElementById(d.id);var i=e.uid(),r="undefined"!=typeof d.checked_value?n==d.checked_value:!!n;t.className+=" dhx_cal_checkbox";var o="<input id='"+i+"' type='checkbox' value='true' name='"+d.name+"'"+(r?"checked='true'":"")+"'>",_="<label for='"+i+"'>"+(e.locale.labels["section_"+d.name]||d.name)+"</label>";

if(e.config.wide_form?(t.innerHTML=_,t.nextSibling.innerHTML=o):t.innerHTML=o+_,d.handler){var l=t.getElementsByTagName("input")[0];l.onclick=d.handler}},get_value:function(e,t,n){e=document.getElementById(n.id);var a=e.getElementsByTagName("input")[0];return a||(a=e.nextSibling.getElementsByTagName("input")[0]),a.checked?n.checked_value||!0:n.unchecked_value||!1},focus:function(e){}}});