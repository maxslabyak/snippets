<%@ Import Namespace="System.Web.Optimization" %>
<!DOCTYPE html>
  <html lang="en-us">
  <head runat="server">
      <asp:PlaceHolder ID="bundleStylePlaceholder" runat="server">
        <% var styles = Styles.Render("~/bundles/css");%>
        <%=styles.ToString().Replace("/bundles",string.Format("{0}/bundles","http://your-cdn-path.to/"))%>
    </asp:PlaceHolder>
    <asp:PlaceHolder ID="bundleScriptPlaceholder" runat="server">
        <% var scripts = Scripts.Render("~/bundles/js");%>
        <%=scripts.ToString().Replace("/bundles",string.Format("{0}/bundles","http://your-cdn-path.to/"))%>
    </asp:PlaceHolder>
   </head>
   <body>
      <p>The CSS and JS will be minified and if your CDN supports server mirroring 
      - e.g. grabbing files from your server and then caching them
      </p>
      <p>You can also put the JS placeholder at the bottom, as best practices suggest, unless it is required to be on top like jQuery or webfonts
    </body>
</html>
