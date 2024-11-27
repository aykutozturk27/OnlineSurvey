import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { PollService } from 'src/app/services/poll.service';

@Component({
  selector: 'app-poll-add',
  templateUrl: './poll-add.component.html',
  styleUrls: ['./poll-add.component.css']
})
export class PollAddComponent implements OnInit {

  pollAddForm: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private pollService: PollService,
    private toastrService: ToastrService
  ) { }

  ngOnInit() {
    this.createPollAddForm();
  }

  createPollAddForm(){
    this.pollAddForm = this.formBuilder.group({
      title: ["", Validators.required]
    })
  }

  add(){
    if (this.pollAddForm.valid) {
      let pollModel = Object.assign({}, this.pollAddForm.value);
      this.pollService.add(pollModel).subscribe(response => {        
        this.toastrService.success(response.message,"Başarılı");
      }, responseError => {
        if (responseError.error.ValidationErrors.length > 0) {
          for (let i = 0; i < responseError.error.ValidationErrors.length; i++) {
            this.toastrService.error(responseError.error.ValidationErrors[i].ErrorMessage, "Doğrulama Hatası");
          }
        }
        
      })
    } else{
      this.toastrService.error("Formunuz eksik", "Dikkat");
    }
  }
}
