### .angular Folder
#### angular-webpack
- Webpack helps to efficiently manage and bundle your application's code.
- **Configuration:** You set up Webpack to understand Angular's structure and dependencies. This involves configuring loaders and plugins to handle different file types, such as Typescript, Javascript, HTML, CSS
- **Module Bundling:** Webpack analyzers your application's dependency graph to bundle together all the necessary files into a smaller number of output files.
- Webpack **Optimize:** by Minifying Code, Convert into smaller chunks for efficient loading, Elemenating unused code through tree shaking
- **HMR (Hot Module Replacement)** It provides help for Dev Workflow

#### babel-webpack
- **Configuration** You set up Babel to transpile your Angular application's TypeScript or ECMAScript into browser-compatible Javascript. 
- This involves configuring Babel plugings and presets to handle features not supported by all browsers, such as arrow functions, template literals, and async/await.
- **Transpilation** It convert modern javascript features into older versions.
- **Polyfills** Provide missing featurs in older browsers, by injecting missing features.
- **Development Workflow** You integerate Babel into your Angular development workflow to auto transpile your code during build process. 


3. .editorconfig
4. .gitignore
#### angular.json
- It Contains the Configuration for
- Directory Structure root
- Build Configuration like dist/brower dist/server
- Path of Different Configuration Files
- - polyfills -> zone.js
- - tsconfig.app.json
- - static files
- - styles [bootstrap, material, styles.scss]
- - scripts [] 
- Configuration for File Size Budgets
- Environment Configuration
- - (fileReplacements)
- - Configuration for Dev, Staging, Production Environments
- i18
- testing, e2e
- Configuration for SSR, Prerendering
- - Prerendering Routes


#### package.json
- Web Dependencies
- Dev Dependencies
- Shell Scripts

7. poylyfills.ts
- Contains the Code for Backward Compatibility
```javascript
(window as any).global = window;
```


#### tsconfig files
- **tsconfig** defines TypeScript compiler options and settings for a project.
- - moduleResolution "node"
- - ES Version
- - baseUrl
- - strict mode
- **tsconfig.app.json** configures TypeScript compilation for client-side code in Angular projects.
-  **tsconfig.server.json** configures TypeScript compilation for server-side code in Angular Universal projects.
- **tsconfig.spec.json** configures TypeScript compilation for testing in Angular projects


#### SRC
#### server.ts
- server.ts is the entry point for server-side rendering in Angular Universal applications.
- SSR and Prerendering
1. index.html Files that Surves at the root level of app
2. main.server.ts
3. **main.ts** serves as the entry point for **client-side** Angular applications, while **server.ts** serves as the entry point for server-side rendering (SSR) in Angular Universal applications.
4. **styles.scss** Global CSS in Angular App

#### APP
1. app.module.ts
2. app-routing.module.ts
3. app.module.server.ts
4. app.component.ts


