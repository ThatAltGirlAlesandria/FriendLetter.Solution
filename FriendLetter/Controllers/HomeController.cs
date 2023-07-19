using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
[Route("/postcard")]
  public ActionResult Postcard(string recipient, string sender)
  {
    LetterVariable myLetterVariable = new LetterVariable();
    myLetterVariable.Recipient = recipient;
    myLetterVariable.Sender = sender;
    return View(myLetterVariable);
  }
}