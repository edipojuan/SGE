import { Component, Injector } from '@angular/core';

import { ModalController } from '@ionic/angular';
import { BaseForm } from 'src/app/shared/base/base-form';

@Component({
  selector: 'app-add-lecture',
  templateUrl: './add-lecture.page.html',
  styleUrls: ['./add-lecture.page.scss']
})
export class AddLecturePage extends BaseForm {
  constructor(private modalCtrl: ModalController, injector: Injector) {
    super(injector);
  }

  onInit() {
    this.form = this.formBuilder.group({
      name: [null]
    })
  }

  submit(): void {
    this.modalCtrl.dismiss(this.form.value);
  }

  closeModal() {
    this.modalCtrl.dismiss();
  }
}
