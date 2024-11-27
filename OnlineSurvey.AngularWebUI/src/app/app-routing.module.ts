import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { PollComponent } from './components/poll/poll.component';
import { PollDetailComponent } from './components/poll-detail/poll-detail.component';
import { LoginGuard } from './guards/login.guard';
import { PollAddComponent } from './components/poll-add/poll-add.component';

const routes: Routes = [
  { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'polls', component: PollComponent },

  { path: 'polls/poll-detail/:pollId', component: PollDetailComponent },

  // { path: 'polls/add', component: PollAddComponent, canActivate: [LoginGuard] },
  { path: 'polls/add', component: PollAddComponent, canActivate: [LoginGuard] }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
