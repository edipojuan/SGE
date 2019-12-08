import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { IonicModule } from '@ionic/angular';

import { AddLecturePage } from './add-lecture.page';

const routes: Routes = [
  {
    path: '',
    component: AddLecturePage
  }
];

@NgModule({
  declarations: [AddLecturePage],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    IonicModule,
    RouterModule.forChild(routes)
  ]
})
export class AddLecturePageModule { }
