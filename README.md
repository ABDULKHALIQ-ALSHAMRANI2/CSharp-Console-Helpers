<h1>CSharp-Console-Helpers</h1>
<p>Welcome to <strong>CSharp-Console-Helpers</strong>, a growing, open-source class library dedicated to providing reusable utility helpers, defensive programming snippets, and robust input validators for C# Console Applications.</p>

<p>The goal of this repository is to serve as a comprehensive toolbox for developers, offering production-ready code blocks that eliminate redundancy, sanitize inputs, and prevent runtime crashes.</p>

<hr>

<h2>Developer & Maintainer</h2>
<p>Developed with 💻 by <strong>C#Fazza++</strong>. This repository is continuously updated with new helper methods and classes as new development challenges are solved.</p>

<h2>License</h2>
<p>This library is distributed under the <strong>MIT License</strong> — feel free to copy, modify, and use the code in both personal and commercial projects.</p>

<hr>

<h2>Library Structure & Available Tools</h2>
<p>The repository is organized into logical utility modules. Below is the current map of available tools that you can copy and integrate into your projects:</p>

<h3>1. Input Validation Module (<code>InputValidator.cs</code>)</h3>
<p>Focuses on capturing user input safely, filtering out illegal characters, and forcing correct data types without crashing the application stream.</p>

<ul>
    <li>
        <strong><code>PrintUserDateTime()</code></strong>: 
        Intercepts console inputs, cleans wildcard characters (like asterisks <code>*</code>), verifies the text against 5 distinct date formats simultaneously using <code>DateTime.TryParseExact</code>, and securely loops until a valid date is acquired.
    </li>
</ul>

<h4>Supported Text Patterns for Date Parsing:</h4>
<table>
    <thead>
        <tr>
            <th style="text-align: left; padding: 8px; border-bottom: 2px solid #ddd;">Pattern Type</th>
            <th style="text-align: left; padding: 8px; border-bottom: 2px solid #ddd;">Accepted Example</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td style="padding: 8px; border-bottom: 1px solid #eee;">Slash Separator</td>
            <td style="padding: 8px; border-bottom: 1px solid #eee;"><code>20/05/2026</code></td>
        </tr>
        <tr>
            <td style="padding: 8px; border-bottom: 1px solid #eee;">Dash Separator</td>
            <td style="padding: 8px; border-bottom: 1px solid #eee;"><code>20-05-2026</code></td>
        </tr>
        <tr>
            <td style="padding: 8px; border-bottom: 1px solid #eee;">Dot Separator</td>
            <td style="padding: 8px; border-bottom: 1px solid #eee;"><code>20.05.2026</code></td>
        </tr>
        <tr>
            <td style="padding: 8px; border-bottom: 1px solid #eee;">Space Separator</td>
            <td style="padding: 8px; border-bottom: 1px solid #eee;"><code>20 05 2026</code></td>
        </tr>
        <tr>
            <td style="padding: 8px; border-bottom: 1px solid #eee;">Comma Separator</td>
            <td style="padding: 8px; border-bottom: 1px solid #eee;"><code>20,05,2026</code></td>
        </tr>
        <tr>
            <td style="padding: 8px; border-bottom: 1px solid #eee;">Wildcard Asterisk (Auto-Sanitized)</td>
            <td style="padding: 8px; border-bottom: 1px solid #eee;"><code>20*05*2026</code></td>
        </tr>
    </tbody>
</table>

<hr>
<h3>2. DateTime & Storage Module (<code>DateTimeHelper.cs</code>)</h3>
<p>Provides optimized methods to convert local date/time into UTC Ticks (long integers) for lightweight database storage, and securely rebuilds them back to the user's timezone.</p>
<ul>
    <li><code>ConvertToUtcTicks(DateTime localDateTime)</code>: Returns a 64-bit signed integer (Ticks).</li>
    <li><code>ConvertFromUtcTicks(long utcTicks)</code>: Returns a local DateTime object.</li>
</ul>

<h2>Future Roadmap (Upcoming Modules)</h2>
<p>New utilities are actively being developed and will be added to this library soon:</p>
<ul>
    <li><strong>Text Sanitization Helpers:</strong> String manipulation tools to strip spaces, scripts, and unwanted characters.</li>
    <li><strong>Numeric Validators:</strong> Secure parsing for phone numbers, pricing formats, and range boundaries.</li>
    <li><strong>Data Formatter Tools:</strong> Clean presentation formats for console layouts and tables.</li>
</ul>

<h2>Quick Integration Example</h2>
<pre style="background-color: #f6f8fa; padding: 16px; border-radius: 6px; line-height: 1.25;">
<code>
using CSharpConsoleHelpers;

class Program
{
    static void Main(string[] args)
    {
        // Call the static helper directly from the InputValidator library
        InputValidator.PrintUserDateTime();
    }
}
</code>
</pre>
