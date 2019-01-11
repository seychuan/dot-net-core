# dot-net-core
.Net Core Sample Code

#Load External Controller
1. Assumming WebAPI.Controller is an external Controller assembly.
2. After compile WebAPI.Controller project, copy the assembly to the WebAPI.Main project output folder.
3. Set WebAPI.Main project as Default project.
4. Run the project.
5. You should be able to call the endpoint in Web.Controller project.

###How this works?
1. In the AddExternalControllers extension, the assemblies is being added to the Mvc with **AddApplicationPart**.
2. Remember to call the **AddControllersAsServices** after adding the assemblies, otherwise Mvc will not register the controllers in the assemblies.
