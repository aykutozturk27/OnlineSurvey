import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { PollComponent } from './components/poll/poll.component';
import { PollDetailComponent } from './components/poll-detail/poll-detail.component';
import { LoginGuard } from './guards/login.guard';
import { PollAddComponent } from './components/poll-add/poll-add.component';
import { OptionComponent } from './components/option/option.component';
import { OptionAddComponent } from './components/option-add/option-add.component';
import { PollResultComponent } from './components/poll-result/poll-result.component';

const routes: Routes = [
  { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'polls', component: PollComponent },
  { path: 'options', component: OptionComponent },

  { path: 'polls/poll-detail/:pollId', component: PollDetailComponent },
  { path: 'polls/poll-result/:pollId', component: PollResultComponent },

  { path: 'polls/add', component: PollAddComponent },
  { path: 'options/add', component: OptionAddComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
