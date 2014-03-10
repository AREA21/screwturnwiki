Browser check / user agent
robvdkamp|2010/04/01 16:52:28
##PAGE##
<code html><script type="text/javascript" language="javascript">
// Firefox
if (navigator.userAgent.indexOf("Firefox")!=-1 || navigator.userAgent.indexOf("Safari")!=-1)
{ }

// IE
if (navigator.userAgent.indexOf("MSIE")!=-1 && navigator.userAgent.indexOf("Opera")==-1) 
{ }

// IE8
if (navigator.userAgent.indexOf("MSIE 8")!=-1) 
{ }
</script></code>