# Password-generator

### *What is it?*
> It is a open source generator which generates passwords to your needs. **The code is writetn in C#**.

### *How to install*
> If you want to install the full project, then download the full repository and open the [PasswordGenerator.sln](https://github.com/iLoveBread-Code/Password-generator/blob/main/PasswordGenerator.sln) file in Visual Studio Community.
> 
> If you want to download the application only, [click here](https://github.com/iLoveBread-Code/Password-generator/raw/main/PasswordGenerator/bin/Release/PasswordGenerator.exe)

### *How to use the generator*
1. * Check the checkboxes that are needed for your password.
   * Choose a password length (custom password length is also available
2. Press *Create* to generate the password. The password will appear in the textbox below the *Create* button.
3. To copy the password, simply press *Copy Password* and it will be copied to your clipboard.

### *Explaining the code*
The main code is in the [Form.cs](https://github.com/iLoveBread-Code/Password-generator/blob/main/PasswordGenerator/Form1.cs) file. You can follow along there if you want to know how the generator was made.

<details closed><summary>Uppercase checkbox checked or not</summary>

```csharp
private void chbxUpper_CheckedChanged(object sender, EventArgs e)
{
    if(chbxUpper.Checked == true)
    {
        addUpperCase = true;
    }
    else if (chbxUpper.Checked == false)
    {
        addUpperCase = false;
    }
}
```

</details>

<details><summary>Numbers checkbox checked or not</summary>

```csharp
private void chbxNumbers_CheckedChanged(object sender, EventArgs e)
{
    if (chbxNumbers.Checked == true)
    {
        addNumbers = true;
    }
    else if (chbxNumbers.Checked == false)
    {
        addNumbers = false;
    }
}
```

</details>

<details><summary>Symbols checkbox checked or not</summary>

```csharp
private void chbxSpecial_CheckedChanged(object sender, EventArgs e)
{
    if (chbxSpecial.Checked == true)
    {
        addSymbols = true;
    }
    else if (chbxSpecial.Checked == false)
    {
        addSymbols = false;
    }
}
```

</details>

<details><summary>Creation of the generatePassword string</summary>

```csharp
static string generatePassword(int length)
{
    // Base string for the valid characters.
    validChars = "abcdefghijklmnopqrstuvwxyz";
    // Check what checkboxes are ticked and addd the belonging characters to the base string.
    if (addUpperCase == true)
    {
        validChars +="ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    }
    if (addNumbers == true)
    {
        validChars += "1234567890";
    }
    if (addSymbols == true)
    {
        validChars += "?!@#$%^&*";
    }

    // Generate the password using a randomizer that takes a random character from the validChars string.
    StringBuilder res = new StringBuilder();
    Random rnd = new Random();
    while (0 < length--)
    {
        res.Append(validChars[rnd.Next(validChars.Length)]);
    }
    return res.ToString();
}
```

</details>

<details><summary>The event when the Create button is clicked</summary>

```csharp
private void btnCreate_Click_1(object sender, EventArgs e)
{
    try
    {
        // Password length.
        int length = Convert.ToInt32(cbxAmount.Text);

        // Generate the password string.
        pass = generatePassword(length);

        // Show password in application.
        txtPassword.Text = pass;
    }
    catch (Exception)
    {
        MessageBox.Show("Please select a password length.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
```

</details>

<details><summary>The event when the Copy Password button is clicked</summary>

```csharp
private void btnCopy_Click(object sender, EventArgs e)
{
    try
    {
        // Copies the password to your clipboard and tells the user that it copied the password.
        Clipboard.SetText(txtPassword.Text);
        MessageBox.Show("Text copied.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    catch (Exception)
    {
        // Gives a MessageBox that there is nothing to copy in the textbox.
        MessageBox.Show("There is nothing to copy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
```

</details>

#### *Enjoy the password generator*
