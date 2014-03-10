IIS6 Support for Ms Office2007
devid|2010/02/17 16:57:31
##PAGE##
===IIS6 support for Ms Office2007===
<pre>
Steps:  
   1. Open Computer Management. (Right-click My Computer... Manage...)
   2. Right-click Internet Information Services (IIS) Management... Properties...
   3. Click MIME Types...
   4. Click New... and add the followings:

Extension       MIME Type
.xlsx       application/vnd.openxmlformats-officedocument.spreadsheetml.sheet
.xltx       application/vnd.openxmlformats-officedocument.spreadsheetml.template
.potx       application/vnd.openxmlformats-officedocument.presentationml.template
.ppsx       application/vnd.openxmlformats-officedocument.presentationml.slideshow
.pptx       application/vnd.openxmlformats-officedocument.presentationml.presentation
.sldx       application/vnd.openxmlformats-officedocument.presentationml.slide
.docx       application/vnd.openxmlformats-officedocument.wordprocessingml.document
.dotx       application/vnd.openxmlformats-officedocument.wordprocessingml.template
.xlam       application/vnd.ms-excel.addin.macroEnabled.12
.xlsb       application/vnd.ms-excel.sheet.binary.macroEnabled.12

N.B.:[http://support.microsoft.com/kb/936496/en-us|These MIME types were added to IIS7 as noted in KB936496.] 
</pre>
{TOP}