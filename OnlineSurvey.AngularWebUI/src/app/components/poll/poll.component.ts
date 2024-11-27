import { Component, OnInit } from '@angular/core';
import { Poll } from 'src/app/models/poll';
import { PollService } from 'src/app/services/poll.service';

@Component({
  selector: 'app-poll',
  templateUrl: './poll.component.html',
  styleUrls: ['./poll.component.css']
})
export class PollComponent implements OnInit {
  polls: Poll[] = [];
  dataLoaded = false;

  filterText = "";

  constructor(private pollService: PollService) { }

  ngOnInit() {
    this.getPolls();
  }

  getPolls(){
    this.pollService.getPolls().subscribe(response => {
      this.polls = response.data;
      this.dataLoaded = true;
    })
  }

}
