<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="js.WebForm1" %>

<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Java Script tEster</h1>
      

<input id="txtName"  onkeydown="Changed();" style="width:500px; height:500px; "   />
     
    </div>
    </form>
     <script  >
         function Changed() {
             var findMeBlue = ['select', 'from', '*', 'where', 'into'];
             var myString = document.getElementById('txtName').value;
             var spliceMe = myString.split(' ');
             for (var str in spliceMe) {

                 for (var find in findMeBlue) {
                     if (findMeBlue[find] === spliceME[str]) {
                         spliceME[str] = givemecolor('blue', spliceME[str]);
                          }

                 }
             }
             document.getElementById('txtName').innerHTML = spliceME;
         }

         function givemecolor(thecolor, thetext) {
             return '<span style="color:' + thecolor + '>' + thetext + '</span>';
         }
</script>
</body>
</html>
