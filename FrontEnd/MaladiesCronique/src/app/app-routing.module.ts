import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { isAuthenticatedGuard } from './middlewares/is-authenticated.guard';

const routes: Routes = [
  {
    path: "auth",
    loadChildren: () => import("./components/auth/auth.module").then((auth) => auth.AuthModule),
    //canActivate : [isAuthenticatedGuard]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
