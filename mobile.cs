@import 'global';
$nav_size: 60px;
// LOADING
.t-loading {
  transition: 0.3s;
  opacity: 0;
}
.is-loading {
  overflow: hidden;
  height: 100vh;
  .t-loading {
    background-color: rgba(255, 255, 255, 0.8);
    backdrop-filter: blur(4px);
    position: fixed;
    left: 0;
    right: 0;
    top: 0;
    bottom: 0;
    z-index: 10000;
    opacity: 1;
    &::before {
      content: '';
      position: absolute;
      left: calc(50% - 25px);
      top: calc(50% - 25px);
      z-index: 100;
      width: 50px;
      height: 50px;
      display: inline-block;
      border-width: 3px;
      border-color: rgba(0, 0, 0, 0.1);
      border-top-color: $teal;
      animation: spin 1s infinite linear;
      border-radius: 100%;
      border-style: solid;
    }
  }
}
// HEADER
.site-header {
  position: sticky;
  top: 0;
  left: 0;
  right: 0;
  background-color: #ffffffcc;
  z-index: 900;
  backdrop-filter: blur(6px);
  -webkit-backdrop-filter: blur(6px);
  box-shadow: var(--s-shadow-2);
  height: $nav_size;
}
.site-logo {
  padding: 50px 20px 0;
  text-align: center;
  line-height: 0;
}
.btn-lang {
  background-color: $blue;
  width: 26px;
  height: 26px;
  font-family: var(--s-heading);
  font-size: 14px;
  line-height: 27px;
  border-radius: 50%;
  text-align: center;
  color: #fff;
  z-index: 900;
  position: absolute;
  top: 10px;
  right: 10px;
  display: block;
  &:hover,
  &:active {
    color: #fff;
  }
}
// NAV
.site-nav {
  text-align: center;
  line-height: 1;
  a {
    flex-direction: column;
    gap: 0;
    cursor: pointer;
    color: #1a477f;
  }
  span {
    display: block;
    white-space: nowrap;
    font-size: 13px;
    padding: 6px 0 2px;
    @media (min-width: 380px) {
      font-size: 15px;
    }
  }
  em {
    font-style: normal;
  }
  ul {
    padding: 0;
    margin: 0;
    display: grid;
    grid-template-columns: repeat(4, 1fr);
  }
  li {
    list-style: none;
    height: $nav_size;
    padding: 8px 0;
    box-shadow: inset 1px 1px 0 #e6e6e6;
  }
  img,
  svg {
    height: 24px;
    width: auto;
    display: block;
    margin: 0 auto;
  }
  .active {
    svg {
      color: #fff;
      background-color: #00a0a9;
      border-radius: 5px;
      padding: 3px;
    }
  }
  &.-member {
    .m-register,
    .m-manual,
    .m-docs {
      display: none;
    }
  }
}

// BODY
.site-body {
  min-height: 140px;
  position: relative;
  h1 {
    font-weight: bold;
    text-align: center;
    z-index: 2;
    position: relative;
    margin-bottom: 20px;
    + .sub {
      margin-top: -15px;
    }
  }
  > .t-sec {
    padding-left: 0;
    padding-right: 0;
  }
}

h1 + h2 {
  margin-top: -16px;
  &.sub {
    margin-top: -20px;
    font-size: 1.2em;
    text-align: center;
  }
}

// STEP
.t-step {
  counter-reset: step;
  font-family: $heading;
  display: flex;
  margin: 0 auto 16px;
  padding: 0;
  max-width: 760px;
  li {
    list-style-type: none;
    width: 33.333333%;
    font-size: 16px;
    position: relative;
    text-align: center;
    color: $muted;
    &:before {
      width: 30px;
      height: 30px;
      content: counter(step);
      counter-increment: step;
      line-height: 28px;
      border: 2px solid $muted;
      display: block;
      text-align: center;
      margin: 0 auto 6px auto;
      border-radius: 50%;
      background-color: white;
      font-weight: bold;
    }
    &:after {
      width: 100%;
      height: 2px;
      content: '';
      position: absolute;
      background-color: #cfd9e5;
      border-bottom: 1px solid #f8fbff;
      top: 15px;
      left: -50%;
      z-index: -1;
    }
    &:first-child:after {
      content: none;
    }
    &:active,
    &.active {
      color: $teal;
      &:before {
        border-color: $teal;
      }
    }
  }
  span {
    white-space: nowrap;
    @media (min-width: 768px) {
      display: block;
      position: relative;
      font-size: 15px;
    }
  }
}

// OTP
.t-otp {
  display: flex;
  justify-content: center;
  gap: 6px;
  margin-bottom: var(--s-box);
  input {
    width: 44px;
    height: 64px;
    font-size: 32px;
    text-align: center;
    padding: 3px;
  }
  @media (min-width: 360px) {
    gap: 10px;
  }
}

// ROUNDS
.r-all {
  border-radius: 3px;
  overflow: hidden;
  box-shadow: $box-shadow;
  > h2 {
    background-color: $blue;
    border-radius: 5px 5px 0 0;
    color: #fff;
    padding: 8px 16px;
    margin: 0;
  }
  header {
    display: flex;
    position: relative;
    font-family: $heading;
    cursor: pointer;
    * {
      pointer-events: none;
    }
    b {
      width: 50px;
      display: flex;
      flex-direction: column;
      align-items: center;
      justify-content: center;
      font-size: 1.5em;
      line-height: 1.2;
    }
    h3 {
      color: #fff;
      margin: 0;
      flex: 1;
      padding: 10px 40px 10px 16px;
    }
    small {
      display: block;
      font-size: 0.75em;
    }
  }
  .active {
    > header {
      .i-down {
        transform: scaleY(-1);
      }
    }
    > .content {
      height: auto;
      opacity: 1;
      padding: 16px;
    }
    &.r-3,
    &.r-4 {
      > .content:not(.-announce) {
        padding: 0 16px;
      }
    }
  }
  .i-down {
    position: absolute;
    right: 20px;
    top: calc(50% - 9px);
  }
  .content {
    padding: 0 16px;
    text-align: center;
    height: 0;
    overflow: hidden;
    opacity: 0;
    transition: 0.3s ease;
    > h3 {
      color: $blue;
      margin: 4px 0;
      font-weight: bold;
    }
    > h4 {
      color: $blue;
      margin: 4px 0;
    }
  }
}

.r-counter {
  color: $red;
  display: flex;
  justify-content: center;
  font-family: $heading;
  line-height: 1.1;
  padding-left: 0;
  margin: 12px 0;
  font-size: 1.125em;
  li {
    list-style: none;
    text-align: center;
    padding: 0 6px;
  }
  b {
    font-size: 1.7em;
    display: block;
  }
}
.r-choose {
  padding-left: 0;
  li {
    list-style: none;
    background-color: #fff;
    margin-bottom: -1px;
    overflow: hidden;
    z-index: 1;
    position: relative;
    &:first-child {
      border-top-left-radius: 5px;
      border-top-right-radius: 5px;
      label {
        border-top-left-radius: 5px;
        border-top-right-radius: 5px;
      }
    }
    &:last-child {
      &:not(.error),
      & .t-collapse {
        border-bottom-left-radius: 5px;
        border-bottom-right-radius: 5px;
      }
      &:not(.error) label {
        border-bottom-left-radius: 5px;
        border-bottom-right-radius: 5px;
      }
    }
    &.active {
      z-index: 2;
      label {
        border: 2px solid $teal;
      }
      .num {
        border-color: $teal transparent transparent transparent;
      }
    }
    &.noti {
      margin: 10px 10px 10px 20px;
      border: 1px solid $orange;
      padding: 12px 16px !important;
      border-left-width: 4px;
      background-color: $orange_bg_alt;
      text-align: left;
      color: $brown;
    }
  }
  .action {
    padding: 16px;
    border: 1px solid;
    h4 {
      margin: 4px 0 16px;
    }
  }
  label {
    display: block;
    position: relative;
    text-align: left;
    padding: 16px 16px 16px 54px;
    line-height: 1.3;
    border: 1px solid;
    cursor: pointer;
    border-color: $muted;
  }
  strong {
    display: block;
    &.color-green {
      margin-bottom: 6px;
    }
  }
  .num {
    position: absolute;
    background: none;
    top: -1px;
    left: -1px;
    z-index: 2;
    width: 0;
    height: 0;
    border-style: solid;
    border-width: 36px 36px 0 0;
    border-color: $teal transparent transparent transparent;
    b {
      position: absolute;
      left: 3px;
      top: -32px;
      z-index: 10;
      font-size: 14px;
      color: #fff;
      min-width: 16px;
      text-align: center;
    }
  }
  input {
    position: absolute;
    left: 18px;
    top: 24px;
  }
  .u-logo {
    float: right;
    margin: 0 0 10px 10px;
  }
  .score {
    font-size: 0.9em;
    font-weight: bold;
    color: $teal;
    position: absolute;
    bottom: 16px;
  }
  hr {
    margin: 16px -16px 16px -32px;
    border-top: 1px dashed $light_green;
  }

  &.-done {
    li {
      label {
        border-color: $light_green;
        border-radius: 5px;
        padding-left: 32px;
      }
    }
    .num {
      border-color: $light_green transparent transparent transparent;
    }
    .i-check {
      position: absolute;
      top: -27px;
      left: 5px;
      width: 12px;
      height: 12px;
    }
  }
  &.-cancel {
    li {
      label {
        border-color: $red;
        border-radius: 5px;
        padding-left: 32px;
      }
    }
    .num {
      border-color: $red transparent transparent transparent;
    }
    .i-check {
      position: absolute;
      top: -29px;
      left: 3px;
      width: 14px;
      height: 14px;
      background-image: url('../img/i/i-check-no.svg');
    }
  }
  &.-fav,
  &.-drag,
  &.-confirmed {
    margin-top: 0;
    label {
      padding-left: 32px;
      padding-bottom: 40px;
      pointer-events: none;
      cursor: unset;
    }
    .u-logo {
      margin: 22px 0 10px 10px;
    }
    .i-del {
      position: absolute;
      right: 10px;
      top: 10px;
      opacity: 0.7;
      cursor: pointer;
      transition: 0.3s;
      &:hover {
        opacity: 1;
      }
      &:active {
        opacity: 0.8;
      }
    }
  }
  &.-drag {
    margin: 0 -10px;
    li {
      padding: 10px 10px 10px 20px;
      cursor: move;
      border-radius: 5px;
    }
    label {
      border-radius: 5px;
      padding-left: 16px;
    }
    .order {
      margin: -16px 0 10px -16px;
      background-color: $r_3;
      color: #fff;
      padding: 4px 8px 3px;
      font-size: 0.8em;
      font-weight: bold;
      width: 80px;
      text-align: center;
      border-radius: 0 0 5px 0;
    }
    .i-del {
      right: 20px;
      top: 20px;
    }
    .i-drag {
      position: absolute;
      top: calc(50% - 7px);
      left: -20px;
    }
  }
  li {
    &.moving {
      opacity: 0.5;
      label {
        border-width: 3px;
      }
    }
    &.over {
      label {
        border: 3px dotted $orange;
      }
    }
  }
  &.-confirmed {
    .i-drag,
    .i-del {
      display: none;
    }
    li {
      margin-top: 12px;
      &.action {
        margin-top: -5px;
        z-index: 3;
      }
      &.active {
        border-top-width: 2px;
      }
      &.noti {
        margin: 12px 0;
        border-radius: 5px;
      }
    }
    label {
      border-radius: 5px;
      padding-left: 16px;
    }
  }

  .order {
    margin: -16px 0 10px -16px;
    background-color: $r_3;
    color: #fff;
    padding: 4px 8px 3px;
    font-size: 0.8em;
    font-weight: bold;
    width: 80px;
    text-align: center;
    border-radius: 0 0 5px 0;
  }
  .error {
    margin: 10px 0;
    label {
      border-color: $red;
    }
    .order {
      background-color: $red;
    }
    .num {
      border-color: $red transparent transparent transparent;
    }
    .t-toggle {
      color: red;
      padding: 6px 16px 4px 12px;
      font-family: $heading;
      display: flex;
      align-items: center;
      font-size: 1.125em;
      i {
        margin: -5px 0 0 auto;
      }
    }
    ul {
      padding-left: 0;
    }
    .t-collapse {
      text-align: left;
      margin: -2px 0 0;
      background-color: #fff;
      border: 1px solid $red;
      border-top-style: dashed;
      position: relative;
      &.active {
        > .t-content {
          padding: 2px 16px 10px 12px;
        }
      }
    }
    .t-content {
      padding: 0 16px 0 12px;
      font-size: 0.9em;
      li {
        display: flex;
        flex-wrap: wrap;
        align-items: center;
        gap: 6px;
      }
    }
    .reprocess {
      color: $red;
    }
  }
  &.-reprocess {
    li {
      margin-top: 12px;
    }
    label {
      border-radius: 5px;
    }
    .order {
      margin-left: -54px;
    }
    input {
      top: 38px;
    }
    .error {
      hr {
        margin-left: -54px;
        border-top-color: $red;
      }
    }
    &.-ready {
      label {
        padding-left: 20px;
      }
      .order {
        margin-left: -20px;
      }
      input {
        display: none;
      }
      .noprocess {
        display: none;
      }
    }
  }
  .noprocess {
    opacity: 0.8;
    label {
      background-color: #f0f0f0;
      background: repeating-linear-gradient(-45deg, #f4f4f4, #f4f4f4 10px, #fff 10px, #fff 20px);
      border-color: $muted;
    }
    .order {
      background-color: $muted;
    }
    .reprocess {
      color: $muted;
    }
  }
  .reprocess {
    position: absolute;
    color: $orange;
    font-size: 0.84em;
    font-weight: bold;
    top: 4px;
    left: 90px;
  }
}

.u-logo {
  background-size: contain;
  background-repeat: no-repeat;
  width: 60px;
  height: 60px;
  display: inline-block;
}
.i-hearts {
  display: flex;
  justify-content: center;
  flex-wrap: wrap;
  margin: 6px 0 16px;
  small {
    width: 100%;
    font-family: $heading;
    font-size: 1.125em;
    color: $red;
    text-align: center;
    font-weight: bold;
  }
}
.r-timeline {
  text-align: left;
  padding: 0;
  margin: 0;
  li {
    list-style: none;
    display: flex;
    &:not(:last-child) {
      margin-bottom: 10px;
    }
  }
  i {
    width: 34px;
    padding-top: 2px;
  }
  p {
    margin: 0;
  }
}
.r-1 {
  header {
    b {
      background-color: $r_1_no;
      color: $r_1;
    }
    h3 {
      background-color: $r_1;
    }
  }
  .num {
    border-color: $r_1 transparent transparent transparent;
  }
  .content {
    background-color: $r_1_bg;
  }
  label,
  .action {
    border-color: $r_1;
  }
}
.r-2 {
  header {
    b {
      background-color: $r_2_no;
      color: $r_2;
    }
    h3 {
      background-color: $r_2;
    }
  }
  .num {
    border-color: $r_2 transparent transparent transparent;
  }
  .content {
    background-color: $r_2_bg;
  }
  label,
  .action {
    border-color: $r_2;
  }
}
.r-3 {
  header {
    b {
      background-color: $r_3_no;
      color: $r_3;
    }
    h3 {
      background-color: $r_3;
    }
  }
  .num {
    border-color: $r_3 transparent transparent transparent;
  }
  .content {
    background-color: #fff;
    &.-announce {
      background-color: $r_3_bg;
    }
    h3 + small {
      display: block;
    }
  }
  label,
  .action {
    border-color: $r_3;
  }
  .t-collapse {
    margin: 0 -16px;
    border-bottom: 3px solid #e6f1fe;
  }
  h4 {
    margin: 0;
    color: $blue;
  }
  .btn-add {
    font-size: 1.125em;
    font-weight: bold;
    padding: 6px 10px 5px;
    border-color: $r_3;
    color: $r_3;
    min-width: 230px;
    font-family: $heading;
    border: 1px solid $teal;
    margin-bottom: var(--s-space);
    border-radius: 3px;
    justify-content: center;
  }
  .btn-main {
    min-width: 230px;
  }
}
.r-4 {
  header {
    b {
      background-color: $r_4_no;
      color: $r_4;
    }
    h3 {
      background-color: $r_4;
    }
  }
  .num {
    border-color: $r_4 transparent transparent transparent;
  }
  .content {
    background-color: $r_4_bg;
  }
  .t-collapse {
    margin: 0 -16px;
  }
  label,
  .action {
    border-color: $r_4;
  }
}
// @keyframes jiggle_1 {
//   0% {
//     transform: rotate(-1deg);
//     animation-timing-function: ease-in;
//   }

//   50% {
//     transform: rotate(0.9deg);
//     animation-timing-function: ease-out;
//   }
// }

// @keyframes jiggle_2 {
//   0% {
//     transform: rotate(1deg);
//     animation-timing-function: ease-in;
//   }

//   50% {
//     transform: rotate(-0.8deg);
//     animation-timing-function: ease-out;
//   }
// }
// @keyframes jiggle_3 {
//   0% {
//     transform: rotate(1.2deg);
//     animation-timing-function: ease-in;
//   }

//   50% {
//     transform: rotate(-0.5deg);
//     animation-timing-function: ease-out;
//   }
// }
.r-choose.-drag > div {
  li {
    transition: 0.3s ease;
  }
  // > div:nth-child(3n) > li:not(:hover) {
  //   animation-name: jiggle_1;
  //   animation-iteration-count: infinite;
  //   animation-direction: alternate;
  //   transform-origin: 50% 6%;
  //   animation-duration: 0.7s;
  //   animation-delay: -0.1s;
  // }
  // > div:nth-child(3n-1) > li:not(:hover) {
  //   animation-name: jiggle_2;
  //   animation-iteration-count: infinite;
  //   animation-direction: alternate;
  //   transform-origin: 45% 5%;
  //   animation-duration: 1s;
  //   animation-delay: -0.4s;
  // }
  // > div:nth-child(3n-2) > li:not(:hover) {
  //   animation-name: jiggle_3;
  //   animation-iteration-count: infinite;
  //   animation-direction: alternate;
  //   transform-origin: 40% 7%;
  //   animation-duration: 0.8s;
  //   animation-delay: -0.3s;
  // }
}
.r-program {
  text-align: center;
  background-color: $blue;
  border-top: 4px solid $teal;
  border-radius: 5px;
  padding: 20px 76px 20px 12px;
  color: #fff;
  font-family: $heading;
  font-size: 1.125em;
  line-height: 1.3;
  margin: 0 auto 20px;
  max-width: 360px;
  position: relative;
  .u-logo {
    width: 60px;
    height: 60px;
    position: absolute;
    right: 16px;
    top: 16px;
  }
  ul {
    padding-left: 0;
    margin: 0;
  }
  li {
    list-style: none;
    text-align: left;
    display: flex;
  }
  i {
    width: 24px;
    min-width: 24px;
    text-align: center;
    margin-right: 10px;
  }
  b {
    font-size: 1.125em;
    padding-bottom: 2px;
    margin-top: -2px;
  }
}
.r-programs {
  .r-program {
    font-size: 1rem;
    margin-bottom: 12px;
    max-width: 480px;
    i {
      width: 18px;
      height: 18px;
    }
  }
  .order {
    margin: -20px 0 16px -12px;
    background-color: $r_3;
    color: #fff;
    padding: 4px 8px 3px;
    font-size: 0.8em;
    font-weight: bold;
    width: 80px;
    text-align: center;
    border-radius: 0 0 5px 0;
  }
}
.r-radio {
  padding-left: 0;
  margin: 1em auto var(--s-space);
  max-width: 360px;
  li {
    list-style: none;
    z-index: 1;
    position: relative;
    &.active {
      z-index: 2;
      label {
        border: 2px solid $teal;
      }
    }
    &:first-child {
      label {
        border-radius: 5px 5px 0 0;
      }
    }
    &:last-child {
      label {
        border-radius: 0 0 5px 5px;
      }
    }
  }
  label {
    display: block;
    position: relative;
    padding: 18px 16px 16px 54px;
    line-height: 1.3;
    border: 1px solid $blue_fade;
    margin-bottom: -1px;
    background-color: #fff;
    color: $blue;
    cursor: pointer;
    small {
      display: block;
      color: $muted;
    }
  }
  input {
    position: absolute;
    left: 18px;
    top: 18px;
  }
}
.r-more {
  > h4 {
    cursor: pointer;
    color: $muted;
    margin-bottom: 0;
    * {
      pointer-events: none;
    }
  }
  .more {
    opacity: 0;
    height: 0;
    overflow: hidden;
    transition: 0.5s ease;
    padding: 0;
  }
  &.active {
    > .more {
      padding: 16px 0;
      height: auto;
      opacity: 1;
    }
    > h4 > .i-more {
      transform: scaleY(-1);
    }
  }
  .r-more {
    h4 {
      font-weight: bold;
      font-size: 1.1em;
    }
    .more {
      padding-bottom: 0;
    }
  }
}
@keyframes gradient {
  0% {
    background-position: 0% 50%;
  }
  50% {
    background-position: 100% 50%;
  }
  100% {
    background-position: 0% 50%;
  }
}
.r-history {
  width: 100%;
  text-align: left;
  font-family: $heading;
  font-size: 1.125em;
  line-height: 1.4;
  margin: 0;
  padding: 0;
  li {
    margin-bottom: 8px;
    padding: 12px 16px 8px;
    list-style: none;
    background-color: rgba(0, 0, 0, 0.04);
    border-radius: 3px;
    border-left: 2px solid rgba(0, 0, 0, 0.1);
  }
  h4 {
    font-size: 1.25em;
    margin: 0;
  }
  time {
    color: rgba(0, 0, 0, 0.4);
    display: block;
    font-size: 0.935em;
    padding-top: 8px;
  }
}
.u-log {
  padding: 10px 0 8px;
  border-bottom: 1px dashed rgba(0, 0, 0, 0.2);
}
.r-reset-bg {
  position: fixed;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  z-index: 905;
  background: linear-gradient(-45deg, #e71a1a, #c20000, #ff6900, #ff3f02);
  background-size: 400% 400%;
  animation: gradient 15s ease infinite;
  &.-danger {
    background: linear-gradient(-45deg, #362e94, #7d2174, #ea0c42, #ff7a00);
    background-size: 400% 400%;
  }
  @media (min-width: 1024px) {
    z-index: 800;
  }
}
.r-reset {
  position: fixed;
  z-index: 910;
  background-color: #fff;
  top: 20px;
  left: 20px;
  right: 20px;
  bottom: 20px;
  padding: 20px;
  mask-image: radial-gradient(circle at top left, transparent 0, transparent 15px, black 16px),
    radial-gradient(circle at top right, transparent 0, transparent 15px, black 16px),
    radial-gradient(circle at bottom left, transparent 0, transparent 15px, black 16px),
    radial-gradient(circle at bottom right, transparent 0, transparent 15px, black 16px);
  mask-position: top left, top right, bottom left, bottom right;
  mask-repeat: no-repeat;
  mask-size: 51% 51%;
  display: flex;
  flex-direction: column;
  justify-content: stretch;
  h1 {
    font-size: 1.4em;
  }
}
.content-scroll {
  -webkit-overflow-scrolling: touch;
  overflow: scroll;
  margin: 0 -20px;
  padding: 0 20px;
  box-shadow: 0 6px 10px rgba(0, 0, 0, 0.1);
}
.content-bottom {
  display: grid;
  grid-template-columns: 1fr 1fr;
  gap: calc(var(--s-space) / 2);
  margin-top: auto;
  height: 50px;
  padding-top: 16px;
  &.-full {
    grid-template-columns: unset;
    height: unset;
  }
}
.r-consent {
  padding-left: 0;
  border-top: 1px solid $line;
  li {
    list-style: none;
    position: relative;
    border-bottom: 1px solid $line;
    padding: 10px 0 10px 32px;
    input {
      position: absolute;
      left: 0;
    }
    label {
      font-family: $body;
      font-size: 0.9357rem;
      cursor: pointer;
      > span {
        display: inline-block;
        &.tab-space {
          padding-left: 16px;
        }
      }
    }
  }
}
@keyframes spin {
  100% {
    transform: rotate(360deg);
  }
}

// ROUND 3 - ADMISSION

.r-3-bar {
  background-color: $r_3_bg;
  color: $teal;
  text-align: left;
  padding: 8px 12px;
  margin: 0;
  font-size: 1.125em;
  display: flex;
  font-weight: bold;
  gap: 6px;
  align-items: center;
  .i-down-teal {
    margin-left: auto;
  }
}
.r-4-bar {
  background-color: #ffffff;
  color: $blue;
  text-align: left;
  padding: 8px 12px;
  margin: 0;
  font-size: 1.125em;
  display: flex;
  font-weight: bold;
  gap: 6px;
  align-items: center;
  &.-border-top {
    border-top: 3px solid rgb(230, 240, 245);
  }
  .i-down-teal {
    margin-left: auto;
  }
}
.t-search {
  margin-bottom: 10px;
  h2 {
    font-size: 1.5em;
    color: #fff;
    font-weight: bold;
  }
  .input-group {
    width: 100%;
    max-width: 400px;
    position: relative;
    margin: 0 auto;
  }
  .i-search {
    position: absolute;
    z-index: 1;
    right: 12px;
    top: calc(50% - 8px);
  }
  input {
    width: 100%;
    &:focus-visible {
      border-color: $teal;
      outline: none;
    }
  }
  .more {
    padding: 16px 0 0;
    display: block;
    font-size: 1.125rem;
    svg {
      vertical-align: -2px;
    }
  }
  a {
    color: #fff;
  }
}
// Round 3 announce

.t-result {
  position: relative;
  margin-top: 20px;
  z-index: 10;
  text-align: left;
  filter: drop-shadow($box-shadow);
  &:after {
    content: '';
    display: block;
    position: absolute;
    left: calc(50% - 5px);
    top: -8px;
    width: 0;
    height: 0;
    border-style: solid;
    border-width: 0 10px 8px 10px;
    border-color: transparent transparent $teal transparent;
    z-index: 2;
  }
  h2 {
    margin: 0;
    padding: 8px var(--s-box);
    background-color: $teal;
    color: #fff;
    width: 100%;
    font-size: 1.125em;
    border-radius: 5px 5px 0 0;
    display: flex;
    align-items: center;
    gap: 6px;
    > i {
      margin-left: auto;
    }
  }
}
.t-programs {
  padding: 0;
  margin: 0;
  background-color: #fff;
  border-radius: 0 0 5px 5px;
  max-height: 60vh;
  overflow: auto;
  li {
    list-style: none;
    display: block;
    padding: 16px 16px 16px 80px;
    position: relative;
    font-size: 0.9em;
    &:nth-child(2n) {
      background-color: #f3f8fd;
    }
    &:last-child {
      border-radius: 0 0 5px 5px;
    }
  }
  .u-logo {
    position: absolute;
    left: 16px;
    top: 22px;
    width: 50px;
    height: 50px;
  }
  .choose {
    position: absolute;
    right: 16px;
    top: 17px;
    color: $teal;
    font-family: $heading;
    display: flex;
    align-items: center;
    gap: 4px;
    font-size: 0.9em;
  }
  a {
    display: block;
    color: $blue;
    line-height: 1.4;
    > b,
    > span {
      display: block;
      font-size: 0.9em;
    }
    strong {
      color: #ff6b00;
    }
  }
  small {
    display: block;
    margin-top: 10px;
    font-weight: bold;
  }
  h3 {
    font-size: 1.25em;
    margin: 0 0 6px;
    font-weight: bold;
    padding-right: 48px;
  }
}
.t-summary {
  border-radius: 5px;
  border: 1px solid $teal;
  font-family: $heading;
  font-size: 1.1em;
  margin-bottom: var(--s-space);
  overflow: hidden;
  background-color: #fff;
  dl {
    margin: 0;
    display: flex;
    justify-content: stretch;
    &:not(:last-child) {
      border-bottom: 1px solid $teal;
    }
  }
  dt {
    padding: 6px 12px;
    text-align: left;
    display: flex;
    flex-wrap: wrap;
    flex: 1;
    gap: 6px;
    font-weight: bold;
  }
  .sales {
    color: $teal;
  }
  del {
    margin-left: auto;
    color: $muted;
    font-weight: normal;
    font-size: 0.9em;
  }
  dd {
    padding: 4px 12px;
    text-align: right;
    background-color: $r_3_bg;
    min-width: 110px;
    font-size: 0.9em;
    color: $blue;
    margin-left: 0;
    b {
      font-size: 1.25em;
    }
  }
  &.-mini {
    max-width: 480px;
    margin: var(--s-space) auto;
  }
}
.t-note {
  font-size: 0.9rem;
  line-height: 1.5;
  margin: 0 auto 24px;
  max-width: 480px;
  text-align: left;
  img {
    height: 30px;
    width: auto;
    margin: 6px 6px 0 0;
  }
  small {
    display: block;
    margin-top: 12px;
  }
  ol {
    padding-left: 1.1em;
    margin: 6px 0;
  }
  h4 {
    text-align: center;
  }
}
.h-status {
  line-height: 1.5;
  font-weight: bold;
}
// REPROCESS

.t-reprocess {
  background-color: #fff;
  padding: var(--s-box);
  border-radius: 3px;
  margin: 0 auto var(--s-space);
  border: 1px solid $orange;
  overflow: hidden;
  &.-full {
    margin: -16px -16px var(--s-space);
    border-width: 2px;
    position: relative;
    padding: calc(var(--s-box) + 6px) var(--s-box) var(--s-box);
  }
  .close {
    background-color: $orange;
    padding: 10px;
    position: absolute;
    top: 0;
    right: 0;
    line-height: 1;
    border-radius: 0 0 0 5px;
    cursor: pointer;
  }
  h4 {
    color: $orange;
    font-weight: bold;
  }
}

.pic-upload {
  display: flex;
  width: 120px;
  height: 157px;
  background-color: $light;
  border-radius: 5px;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  border: 1px dashed $line;
  position: relative;
  label {
    display: block;
    text-align: center;
    font-size: 1em;
    cursor: pointer;
  }
  input {
    position: absolute;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    opacity: 0;
    cursor: pointer;
  }
}
// RECHECK

.recheck-form {
  max-width: 540px;
  margin: 0 auto;
  > h3 {
    margin-bottom: 12px;
  }
  label {
    align-items: center;
    gap: 6px;
    cursor: pointer;
  }
  .xm-box {
    padding-right: 44px;
    margin-bottom: 12px;
    &.-total {
      padding: 0 16px;
      dl {
        margin: 0 -16px;
        padding: 0 0 0 16px;
        border: none;
        align-items: stretch;
        font-family: $heading;
        font-size: 1.125em;
        &:not(:first-of-type) {
          font-size: 1.125em;
          border-top: 1px solid $sky;
        }
        ul {
          margin-top: 6px;
          padding-left: 14px;
        }
        li {
          font-size: 0.84em;
          line-height: 1.3;
          list-style-type: square;
        }
        &.total {
          dt {
            padding-top: 17px;
            font-weight: bold;
          }
        }
      }
      dd {
        width: 96px;
        font-size: 0.96em;
      }
      dd,
      dt {
        padding: 12px 16px 12px 0;
      }
    }
    input {
      position: absolute;
      right: 14px;
      top: 20px;
    }
    .i-chosen {
      position: absolute;
      right: 16px;
      top: 20px;
      width: 24px;
      height: 24px;
    }
  }
  // .r-radio {
  //   max-width: 100%;
  //   i {
  //     width: 24px;
  //     height: 24px;
  //   }
  //   label {
  //     border-color: $sky;
  //     display: flex;
  //     padding: 18px 54px 16px 16px;
  //   }
  //   input {
  //     left: unset;
  //     right: 14px;
  //   }
  // }
  .note {
    font-size: 0.9rem;
    line-height: 1.5;
    margin-bottom: 24px;
    img {
      height: 30px;
      width: auto;
      margin: 6px 6px 0 0;
    }
    small {
      display: block;
      margin-top: 12px;
    }
    ol {
      padding-left: 1.1em;
      margin: 6px 0;
    }
  }
}

// // ANSWERS
// .xm-answers {
//   h2 {
//     text-align: center;
//   }
//   .xm-box {
//     border-color: $r_2;
//     color: $text;
//     display: block;
//     padding-right: 40px;
//     .num {
//       border-color: $r_2 transparent transparent transparent;
//     }
//     .i-answer {
//       position: absolute;
//       right: 16px;
//       top: calc(50% - 12px);
//     }
//   }
// }

// ANSWER
// .xm-answer {
//   h2 {
//     text-align: center;
//   }
//   .xm-box {
//     border-color: $r_2;
//     color: $text;
//     max-width: 480px;
//     margin: 0 auto;
//   }
//   .num {
//     border-color: $r_2 transparent transparent transparent;
//   }
//   dl {
//     border-color: $r_2;
//   }
//   dd {
//     color: $orange;
//     background-color: #fff2f0;
//   }
//   details {
//     max-width: 720px;
//     margin: 0 auto;
//     h2 {
//       margin-bottom: -10px;
//     }
//   }
//   .t-panel {
//     background-color: #fff;
//   }
//   button {
//     cursor: pointer;
//   }
//   .full {
//     width: 100%;
//     margin-top: 6px;
//   }
//   .action {
//     margin-top: var(--s-space);
//   }
// }
.xm-sheets {
  background-color: #fff;
  border: 1px solid $r_2;
  border-radius: 5px;
  margin: var(--s-space) 0;
  h3 {
    margin: 0 0 10px;
  }
  .sheet {
    padding: var(--s-space);
    margin-bottom: var(--s-space);
    border-bottom: 1px solid $r_2;
    &:last-of-type {
      margin-bottom: 0;
      border-bottom: none;
    }
  }
}
.xm-choices {
  padding: 0;
  display: flex;
  flex-wrap: wrap;

  li {
    list-style: none;
    width: 66px;
    margin-bottom: 6px;
    display: flex;
    flex-wrap: wrap;
    align-items: center;
    gap: 6px;
    select,
    input[type='text'] {
      display: none;
    }
    &.active {
      width: 100%;
      select,
      input[type='text'] {
        display: flex;
      }
      input[type='text'] {
        flex: 1;
      }
    }
  }
  label {
    cursor: pointer;
    display: flex;
    gap: 6px;
    align-items: center;
    width: 60px;
  }
}
// PAYMENT
.payment-form-bg {
  position: fixed;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  z-index: 800;
  background: linear-gradient(280deg, #00bad3 0%, #00a5ad 100%);
}
.payment-form {
  position: fixed;
  border-radius: 5px;
  z-index: 810;
  background-color: #fff;
  top: 64px;
  left: 10px;
  right: 10px;
  bottom: 84px;
  padding: 16px 16px 6px;
  display: flex;
  flex-direction: column;
  justify-content: stretch;
  h1 {
    font-size: 1.5em;
  }
  h1,
  h4 {
    font-weight: bold;
  }
  small {
    display: block;
  }
  .meta {
    margin: 16px -16px 0;
    padding: 16px 20px;
    border-top: 1px dashed $teal;
    font-size: 0.8em;
    line-height: 1.4;
    ul {
      margin: 0;
      padding-left: 1.2em;
      list-style-type: square;
    }
  }
  .content-scroll {
    margin: 0 -16px;
    padding: 0 16px;
    overflow-x: visible;
    overflow-y: scroll;
  }
  .content-action {
    border-top: 1px solid $teal;
    margin: auto -16px 0;
    padding: 4px 16px 1px;
    text-align: center;
    color: $blue;
    b {
      font-size: 1.25em;
    }
  }
}

// FOOTER
.site-footer {
  margin-top: auto;
  background-color: $blue;
  color: #eee;
  padding: 30px 20px;
  font-family: $heading;
  line-height: 1.3;
  font-size: 0.9em;
  b {
    font-size: 1.2em;
    display: block;
  }
  .address {
    padding: 12px 0;
    br {
      display: none;
    }
    a {
      color: #fff;
    }
  }
  .social {
    a {
      margin-right: 6px;
    }
  }
}

.r-3-log {
  padding-top: 16px;
  padding-bottom: 16px;
  background-color: #eefeff;
  .r-3-log_header {
    display: flex;
    justify-content: center;
    align-items: center;
    gap: 8px;
  }
}

.t-tabs {
  position: relative;
  .t-tab-nav {
    display: flex;
    list-style: none;
    padding: 0;
    margin: 0;
    li {
      flex: 1;
      padding-top: 6px;
      padding-bottom: 6px;
      color: #00a0a9;
      font-family: var(--s-heading);
      font-weight: bold;
      cursor: pointer;
    }
    li.active {
      color: #fff;
      background-color: #00a3ab;
      border-radius: 10px 0px 0px 0px;
      &:first-child {
        border-radius: 0px 10px 0px 0px;
      }
    }
  }
  .t-tab-content {
    width: 100%;
    opacity: 1;
    height: 0;
    position: absolute;
    opacity: 0;
    left: 0;
    transform: translateY(-3px);
    &.active {
      position: relative;
      top: 0;
      height: auto;
      opacity: 1;
      transform: translateY(0);
      transition: 0.3s opacity ease-in, 0.8s transform ease;
    }
  }
}
.card-log {
  padding: 16px 16px 4px 16px;
  background-color: #ccecee;
  text-align: left;
  border-radius: 1px;
  border: 1px solid #8bc5c9;
  margin-bottom: -1px;
  line-height: 1.5;
  h4 {
    font-size: 1.125em;
  }
  ul {
    list-style-type: square;
    margin: 0;
    padding-left: 16px;
  }
  p {
    margin-top: 0;
    margin-bottom: 8px;
  }
  .datetime {
    padding-top: 4px;
    margin-top: 8px;
    border-top: 1px dashed #a5cfd0;
  }
}

@import 'exam';
