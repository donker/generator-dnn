﻿/*
' Copyright (c) 2017 Dnn Software
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/
using DotNetNuke.Web.Mvc.Routing;

namespace <%= namespace%>.Modules.<%= moduleName %>
{
    public class RouteConfig : IMvcRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapRoute("<%= namespace%>.Modules.<%= moduleName %>", "<%= namespace%>.Modules.<%= moduleName %>", "{controller}/{action}", new[]
            {"<%= namespace%>.Modules.<%= moduleName %>.Controllers"});
        }
    }
}
