<b>Version</b>: v7.1 rev. 130926 and lower

<b>Description</b>:
In Media Library, when attempting to attach a file (image) to an existing item by clicking Attach and Browse, the browse 
button doesn't actually open an "open file" dialog.

The Sitecore Support Team has classified this as a bug and is working on a fix. In the interim, they have issued a 
workaround.

<b>Workaround</b>:
Set the upload mode to Classic in your web.config:
<pre><code>
      &lt;setting name="Upload.Classic" value="true" /&gt;
</code></pre>

If you don't to mess with your freshly edited/downloaded web.config chock-full of changes for v7.1, you can just dump a .config file into your App_Config/Include directory and then delete it when the Sitecore team issues an offiial patch.

You can pull it from here directly.
