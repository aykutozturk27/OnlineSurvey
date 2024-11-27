import { Component, OnInit } from '@angular/core';
import { Option } from 'src/app/models/option';
import { OptionModel } from 'src/app/models/optionModel';
import { OptionService } from 'src/app/services/option.service';

@Component({
  selector: 'app-option',
  templateUrl: './option.component.html',
  styleUrls: ['./option.component.css']
})
export class OptionComponent implements OnInit {

  options: OptionModel[] = [];
  dataLoaded = false;

  filterText = "";

  constructor(private optionService: OptionService) { }

  ngOnInit() {
  }

  getOptions(){
    this.optionService.getOptions().subscribe(response => {
      this.options = response.data;
      this.dataLoaded = true;
    })
  }

}
