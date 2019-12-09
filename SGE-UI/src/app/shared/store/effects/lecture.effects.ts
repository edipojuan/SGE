import { Injectable } from '@angular/core';

import { Actions, createEffect, ofType } from '@ngrx/effects';

import { EMPTY } from 'rxjs';
import { map, mergeMap, catchError } from 'rxjs/operators';

import * as actions from '../actions';

import { LectureService } from 'src/app/services/lecture.service';

@Injectable()
export class LectureEffects {
  tramitar$ = createEffect(() =>
    this.actions$.pipe(
      ofType(actions.get),
      mergeMap(() =>
        this.lectureService.get().pipe(
          map((response) => actions.updateLecture({ response })),
          catchError(() => EMPTY)
        )
      )
    )
  );

  constructor(
    private actions$: Actions,
    private lectureService: LectureService
  ) { }
}
