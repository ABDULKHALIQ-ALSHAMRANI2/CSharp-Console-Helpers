<h1>CSharp-Console-Helpers</h1>
<p>A comprehensive and robust collection of utility helpers and input validators designed specifically for C# Console Applications. This library focuses on ensuring secure, crash-free data parsing and robust defensive programming tactics.</p>

<hr>

<h2>Developer Profile</h2>
<p>Built and maintained with 💻 by <strong>C#Fazza++</strong></p>

<h2>Project License</h2>
<p>This project is open-source and officially licensed under the <strong>MIT License</strong>.</p>

<hr>

<h2>Key Features</h2>
<ul>
    <li><strong>Multi-Format Validation:</strong> Evaluates inputs against 5 different date structures simultaneously.</li>
    <li><strong>Smart Sanitization:</strong> Seamlessly replaces wildcard typing mistakes (such as asterisks <code>*</code>) into valid delimiters.</li>
    <li><strong>Infinite Error Trapping:</strong> Employs a secure loop that gently forces correct syntax without throwing runtime exceptions or crashing the execution stream.</li>
</ul>

<h2>Component Documentation</h2>
<h3>1. InputValidator.PrintUserDateTime()</h3>
<p>This static method intercepts user input from the console console, cleans it, checks it against multiple formats, and safely extracts a valid <code>DateTime</code> object object.</p>

<h4>Supported Input Formats:</h4>
<table>
    <thead>
        <tr>
            <th style="text-align: left; padding: 8px;">Format Structure</th>
            <th style="text-align: left; padding: 8px;">Example Input</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td style="padding: 8px;"><code>dd/MM/yyyy</code></td>
            <td style="padding: 8px;">20/05/2026</td>
        </tr>
        <tr>
            <td style="padding: 8px;"><code>dd-MM-yyyy</code></td>
            <td style="padding: 8px;">20-05-2026</td>
        </tr>
        <tr>
            <td style="padding: 8px;"><code>dd.MM.yyyy</code></td>
            <td style="padding: 8px;">20.05.2026</td>
        </tr>
        <tr>
            <td style="padding: 8px;"><code>dd MM yyyy</code></td>
            <td style="padding: 8px;">20 05 2026</td>
        </tr>
        <tr>
            <td style="padding: 8px;"><code>dd,MM,yyyy</code></td>
            <td style="padding: 8px;">20,05,2026</td>
        </tr>
         <tr>
            <td style="padding: 8px;"><code>dd*MM*yyyy</code> (Auto-Cleaned)</td>
            <td style="padding: 8px;">20*05*2026</td>
        </tr>
    </tbody>
</table>

<br>

<h2>How To Use</h2>
<p>Since the utility class and its methods are marked as <code>static</code>, you can invoke them directly anywhere in your program without creating an instance object:</p>

<pre style="background-color: #f6f8fa; padding: 16px; border-radius: 6px; line-height: 1.25;">
<code>
using CSharpConsoleHelpers;

class Program
{
    static void Main(string[] args)
    {
        // Simply call the helper method to securely process user input
        InputValidator.PrintUserDateTime();
    }
}
</code>
</pre>
