import { Component, OnInit } from '@angular/core';

import { ModalController } from '@ionic/angular';

@Component({
  selector: 'app-add-lecture',
  templateUrl: './add-lecture.page.html',
  styleUrls: ['./add-lecture.page.scss']
})
export class AddLecturePage implements OnInit {

  constructor(private modalCtrl: ModalController) { }

  ngOnInit() {
  }

  closeModal() {
    this.modalCtrl.dismiss();
  }
}
