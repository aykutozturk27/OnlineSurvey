import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PollDetailDto } from 'src/app/models/pollDetailDto';
import { PollService } from 'src/app/services/poll.service';

@Component({
  selector: 'app-poll-detail',
  templateUrl: './poll-detail.component.html',
  styleUrls: ['./poll-detail.component.css']
})
export class PollDetailComponent implements OnInit {
  poll: PollDetailDto;
  dataLoaded = false;

  constructor(
    private pollService: PollService,
    private activatedRoute: ActivatedRoute
  ) { }

  ngOnInit() {
    this.activatedRoute.params.subscribe((params) => {
      if (params['pollId']) {
        this.getPollDetailById(params['pollId'])
      }
    })
  }

  getPollDetailById(id: number){
    this.pollService.getById(id).subscribe((response) => {
      this.poll = response.data;
      this.dataLoaded = true;
    })
  }

}
