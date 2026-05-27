# Basic Tailwind ASP.NET Core MVC Template

This is a bare-bones template for using [TailwindCSS](https://tailwindcss.com/) with ASP.NET Core MVC with [Visual Studio Code](https://code.visualstudio.com/).

This template contains no Bootstrap CSS code.

Prerequisites:

1. [NodeJS](https://nodejs.org/en)
1. [TailwindCSS and Tailwind CLI](https://tailwindcss.com/)
1. [.NET SDK](https://dotnet.microsoft.com/en-us/download)

To run this project, open up a new terminal window and run:

```bash
dotnet watch run
```

Open up another terminal window and run:

```bash
npx @tailwindcss/cli -i ./wwwroot/css/input.css -o ./wwwroot/css/output.css --watch
```

Install the VS Code [Tailwind CSS Intellisense extension](https://marketplace.visualstudio.com/items?itemName=bradlc.vscode-tailwindcss) for the best coding experience with TailwindCSS.
