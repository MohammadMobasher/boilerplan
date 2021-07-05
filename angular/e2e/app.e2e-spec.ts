import { markazTemplatePage } from './app.po';

describe('markaz App', function() {
  let page: markazTemplatePage;

  beforeEach(() => {
    page = new markazTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
