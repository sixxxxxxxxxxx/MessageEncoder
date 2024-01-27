![A nuget package used for encoding and decoding strings.](https://raw.githubusercontent.com/sixxxxxxxxxxx/MessageEncoder/main/images/icon.jpg)

# MessageEncoder

A nuget package used for encoding and decoding strings.

## Badges

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)

stable release version: ![version](https://img.shields.io/badge/version-1.0.2-blue)

## Tech Stack

**C#, .Net6.0, .NetStandard2.1**, 

## How Do I Get Started

First, install NuGet. Then, install MessageEncoder from the package manager console:

```C#   
   NuGet\Install-Package MessageEncoder -Version 1.0.2
```
 This command is intended to be used within the Package Manager Console in Visual Studio, as it uses the NuGet module's version of Install-Package.


Or from the .NET CLI as:
```C#   
   dotnet add package MessageEncoder --version 1.0.2
```

Finally, import into the file:
```C#   
   using MessageEncoder;
```

## Features

- Encode string
- Decode string

## Sample usage

```C#
   Encoder.DecodeMessage(encodedMessage: string);           
```
- Input

| Parameters	   | Type		| Description						 |
| :----------------| :-------	| :----------------------------------|
| `encodedMessage` | `string`   | **Required**. string to be decoded |


- Output

| Type     |
| :------- |
| `string` |

---
```C#
   Excel.EncodeMessage(message: string);
```

- Input

| Parameters  | Type	   | Description						|
| :--------	  | :-------   | :----------------------------------|
| `message`   | `string`   | **Required**. string to be encoded |

- Output

| Type     |
| :------- |
| `string` |




## Thanks to all Contributors

Maintainers:

- [sixxxxxxxxxxx](https://github.com/sixxxxxxxxxxx)

## Contributing

Contributions are always welcome!

See `contributing.md` for ways to get started.

Please adhere to this project's `code of conduct`.
