Scheduler.plugin(function(e){e.attachEvent("onTemplatesReady",function(){this.layers.sort(function(e,t){return e.zIndex-t.zIndex}),e._dp_init=function(t){t._methods=["_set_event_text_style","","changeEventId","deleteEvent"],this.attachEvent("onEventAdded",function(e){!this._loading&&this.validId(e)&&this.getEvent(e)&&this.getEvent(e).layer==t.layer&&t.setUpdated(e,!0,"inserted")}),this.attachEvent("onBeforeEventDelete",function(e){if(this.getEvent(e)&&this.getEvent(e).layer==t.layer){if(!this.validId(e))return;
var a=t.getState(e);return"inserted"==a||this._new_event?(t.setUpdated(e,!1),!0):"deleted"==a?!1:"true_deleted"==a?!0:(t.setUpdated(e,!0,"deleted"),!1)}return!0}),this.attachEvent("onEventChanged",function(e){!this._loading&&this.validId(e)&&this.getEvent(e)&&this.getEvent(e).layer==t.layer&&t.setUpdated(e,!0,"updated")}),t._getRowData=function(e){var t=this.obj.getEvent(e),a={};for(var n in t)0!==n.indexOf("_")&&(a[n]=t[n]&&t[n].getUTCFullYear?this.obj.templates.xml_format(t[n]):t[n]);return a},t._clearUpdateFlag=function(){},t.attachEvent("insertCallback",e._update_callback),t.attachEvent("updateCallback",e._update_callback),t.attachEvent("deleteCallback",function(e,t){this.obj.setUserData(t,this.action_param,"true_deleted"),this.obj.deleteEvent(t)
})},function(){var t=function(e){if(null===e||"object"!=typeof e)return e;var a=new e.constructor;for(var n in e)a[n]=t(e[n]);return a};e._dataprocessors=[],e._layers_zindex={};for(var a=0;a<e.layers.length;a++){if(e.config["lightbox_"+e.layers[a].name]={},e.config["lightbox_"+e.layers[a].name].sections=t(e.config.lightbox.sections),e._layers_zindex[e.layers[a].name]=e.config.inital_layer_zindex||5+3*a,e.layers[a].url){var n=new dataProcessor(e.layers[a].url);n.layer=e.layers[a].name,e._dataprocessors.push(n),e._dataprocessors[a].init(e)
}e.layers[a].isDefault&&(e.defaultLayer=e.layers[a].name)}}(),e.showLayer=function(e){this.toggleLayer(e,!0)},e.hideLayer=function(e){this.toggleLayer(e,!1)},e.toggleLayer=function(e,t){var a=this.getLayer(e);a.visible="undefined"!=typeof t?!!t:!a.visible,this.setCurrentView(this._date,this._mode)},e.getLayer=function(t){var a,n;"string"==typeof t&&(n=t),"object"==typeof t&&(n=t.layer);for(var i=0;i<e.layers.length;i++)e.layers[i].name==n&&(a=e.layers[i]);return a},e.attachEvent("onBeforeLightbox",function(t){var a=this.getEvent(t);
return this.config.lightbox.sections=this.config["lightbox_"+a.layer].sections,e.resetLightbox(),!0}),e.attachEvent("onClick",function(t){var a=e.getEvent(t);return!e.getLayer(a.layer).noMenu}),e.attachEvent("onEventCollision",function(t,a){var n=this.getLayer(t);if(!n.checkCollision)return!1;for(var i=0,d=0;d<a.length;d++)a[d].layer==n.name&&a[d].id!=t.id&&i++;return i>=e.config.collision_limit}),e.addEvent=function(t,a,n,i,d){var r=t;1!=arguments.length&&(r=d||{},r.start_date=t,r.end_date=a,r.text=n,r.id=i,r.layer=this.defaultLayer),r.id=r.id||e.uid(),r.text=r.text||"","string"==typeof r.start_date&&(r.start_date=this.templates.api_date(r.start_date)),"string"==typeof r.end_date&&(r.end_date=this.templates.api_date(r.end_date)),r._timed=this.isOneDayEvent(r);
var _=!this._events[r.id];this._events[r.id]=r,this.event_updated(r),this._loading||this.callEvent(_?"onEventAdded":"onEventChanged",[r.id,r])},this._evs_layer={};for(var t=0;t<this.layers.length;t++)this._evs_layer[this.layers[t].name]=[];e.addEventNow=function(t,a,n){var i={};"object"==typeof t&&(i=t,t=null);var d=6e4*(this.config.event_duration||this.config.time_step);t||(t=Math.round(e._currentDate().valueOf()/d)*d);var r=new Date(t);if(!a){var _=this.config.first_hour;_>r.getHours()&&(r.setHours(_),t=r.valueOf()),a=t+d
}i.start_date=i.start_date||r,i.end_date=i.end_date||new Date(a),i.text=i.text||this.locale.labels.new_event,i.id=this._drag_id=this.uid(),i.layer=this.defaultLayer,this._drag_mode="new-size",this._loading=!0,this.addEvent(i),this.callEvent("onEventCreated",[this._drag_id,n]),this._loading=!1,this._drag_event={},this._on_mouse_up(n)},e._t_render_view_data=function(e){if(this.config.multi_day&&!this._table_view){for(var t=[],a=[],n=0;n<e.length;n++)e[n]._timed?t.push(e[n]):a.push(e[n]);this._table_view=!0,this.render_data(a),this._table_view=!1,this.render_data(t)
}else this.render_data(e)},e.render_view_data=function(){if(this._not_render)return void(this._render_wait=!0);this._render_wait=!1,this.clear_view(),this._evs_layer={};for(var e=0;e<this.layers.length;e++)this._evs_layer[this.layers[e].name]=[];for(var t=this.get_visible_events(),e=0;e<t.length;e++)this._evs_layer[t[e].layer]&&this._evs_layer[t[e].layer].push(t[e]);if("month"==this._mode){for(var a=[],e=0;e<this.layers.length;e++)this.layers[e].visible&&(a=a.concat(this._evs_layer[this.layers[e].name]));
this._t_render_view_data(a)}else for(var e=0;e<this.layers.length;e++)if(this.layers[e].visible){var n=this._evs_layer[this.layers[e].name];this._t_render_view_data(n)}},e._render_v_bar=function(t,a,n,i,d,r,_,l,s){var o=t.id;-1==_.indexOf("<div class=")&&(_=e.templates["event_header_"+t.layer]?e.templates["event_header_"+t.layer](t.start_date,t.end_date,t):_),-1==l.indexOf("<div class=")&&(l=e.templates["event_text_"+t.layer]?e.templates["event_text_"+t.layer](t.start_date,t.end_date,t):l);var c=document.createElement("DIV"),h="dhx_cal_event",v=e.templates["event_class_"+t.layer]?e.templates["event_class_"+t.layer](t.start_date,t.end_date,t):e.templates.event_class(t.start_date,t.end_date,t);
v&&(h=h+" "+v);var u='<div event_id="'+o+'" class="'+h+'" style="position:absolute; top:'+n+"px; left:"+a+"px; width:"+(i-4)+"px; height:"+d+"px;"+(r||"")+'">';return u+='<div class="dhx_header" style=" width:'+(i-6)+'px;" >&nbsp;</div>',u+='<div class="dhx_title">'+_+"</div>",u+='<div class="dhx_body" style=" width:'+(i-(this._quirks?4:14))+"px; height:"+(d-(this._quirks?20:30))+'px;">'+l+"</div>",u+='<div class="dhx_footer" style=" width:'+(i-8)+"px;"+(s?" margin-top:-1px;":"")+'" ></div></div>',c.innerHTML=u,c.style.zIndex=100,c.firstChild
},e.render_event_bar=function(t){var a=this._els.dhx_cal_data[0],n=this._colsS[t._sday],i=this._colsS[t._eday];i==n&&(i=this._colsS[t._eday+1]);var d=this.xy.bar_height,r=this._colsS.heights[t._sweek]+(this._colsS.height?this.xy.month_scale_height+2:2)+t._sorder*d,_=document.createElement("DIV"),l=t._timed?"dhx_cal_event_clear":"dhx_cal_event_line",s=e.templates["event_class_"+t.layer]?e.templates["event_class_"+t.layer](t.start_date,t.end_date,t):e.templates.event_class(t.start_date,t.end_date,t);
s&&(l=l+" "+s);var o='<div event_id="'+t.id+'" class="'+l+'" style="position:absolute; top:'+r+"px; left:"+n+"px; width:"+(i-n-15)+"px;"+(t._text_style||"")+'">';t._timed&&(o+=e.templates["event_bar_date_"+t.layer]?e.templates["event_bar_date_"+t.layer](t.start_date,t.end_date,t):e.templates.event_bar_date(t.start_date,t.end_date,t)),o+=e.templates["event_bar_text_"+t.layer]?e.templates["event_bar_text_"+t.layer](t.start_date,t.end_date,t):e.templates.event_bar_text(t.start_date,t.end_date,t)+"</div>)",o+="</div>",_.innerHTML=o,this._rendered.push(_.firstChild),a.appendChild(_.firstChild)
},e.render_event=function(t){var a=e.xy.menu_width;if(e.getLayer(t.layer).noMenu&&(a=0),!(t._sday<0)){var n=e.locate_holder(t._sday);if(n){var i=60*t.start_date.getHours()+t.start_date.getMinutes(),d=60*t.end_date.getHours()+t.end_date.getMinutes()||60*e.config.last_hour,r=Math.round((60*i*1e3-60*this.config.first_hour*60*1e3)*this.config.hour_size_px/36e5)%(24*this.config.hour_size_px)+1,_=Math.max(e.xy.min_event_height,(d-i)*this.config.hour_size_px/60)+1,l=Math.floor((n.clientWidth-a)/t._count),s=t._sorder*l+1;
t._inner||(l*=t._count-t._sorder);var o=this._render_v_bar(t.id,a+s,r,l,_,t._text_style,e.templates.event_header(t.start_date,t.end_date,t),e.templates.event_text(t.start_date,t.end_date,t));if(this._rendered.push(o),n.appendChild(o),s=s+parseInt(n.style.left,10)+a,r+=this._dy_shift,o.style.zIndex=this._layers_zindex[t.layer],this._edit_id==t.id){o.style.zIndex=parseInt(o.style.zIndex)+1;var c=o.style.zIndex;l=Math.max(l-4,e.xy.editor_width);var o=document.createElement("DIV");o.setAttribute("event_id",t.id),this.set_xy(o,l,_-20,s,r+14),o.className="dhx_cal_editor",o.style.zIndex=c;
var h=document.createElement("DIV");this.set_xy(h,l-6,_-26),h.style.cssText+=";margin:2px 2px 2px 2px;overflow:hidden;",h.style.zIndex=c,o.appendChild(h),this._els.dhx_cal_data[0].appendChild(o),this._rendered.push(o),h.innerHTML="<textarea class='dhx_cal_editor'>"+t.text+"</textarea>",this._quirks7&&(h.firstChild.style.height=_-12+"px"),this._editor=h.firstChild,this._editor.onkeypress=function(t){if((t||event).shiftKey)return!0;var a=(t||event).keyCode;a==e.keys.edit_save&&e.editStop(!0),a==e.keys.edit_cancel&&e.editStop(!1)
},this._editor.onselectstart=function(e){return(e||event).cancelBubble=!0,!0},h.firstChild.focus(),this._els.dhx_cal_data[0].scrollLeft=0,h.firstChild.select()}if(this._select_id==t.id){o.style.zIndex=parseInt(o.style.zIndex)+1;for(var v=this.config["icons_"+(this._edit_id==t.id?"edit":"select")],u="",g=0;g<v.length;g++)u+="<div class='dhx_menu_icon "+v[g]+"' title='"+this.locale.labels[v[g]]+"'></div>";var f=this._render_v_bar(t.id,s-a+1,r,a,20*v.length+26,"","<div class='dhx_menu_head'></div>",u,!0);
f.style.left=s-a+1,f.style.zIndex=o.style.zIndex,this._els.dhx_cal_data[0].appendChild(f),this._rendered.push(f)}}}},e.filter_agenda=function(t,a){var n=e.getLayer(a.layer);return n&&n.visible}})});
//# sourceMappingURL=../sources/ext/dhtmlxscheduler_layer.js.map